    using System;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Net.Mail;
    using System.Net;
    using System.Windows.Forms;
    using Microsoft.Data.SqlClient;
    using QRCoder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Registration
    {
        public partial class Form1 : Form
        {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MICHAEL\Documents\registration.mdf;Integrated Security=True;Connect Timeout=30 ");
        public Form1()
            {
                InitializeComponent();

            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void btnRegister_Click(object sender, EventArgs e)
            {

                {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration VALUES(@email, @firstName, @lastName, @address, @contactNumber, @purpose)", con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text);
                cmd.Parameters.AddWithValue("@Purpose", cmbPurpose.SelectedItem);
                cmd.ExecuteNonQuery();
               

                string Email = txtEmail.Text.Trim();
                    string firstName = txtFName.Text.Trim(); 
                    string lastName = txtLName.Text.Trim();
                    string address = txtAddress.Text.Trim();
                    string contactNumber = txtContact.Text.Trim();
                    string purpose = cmbPurpose.Text.Trim();

                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) 
                   || string.IsNullOrEmpty(purpose))
                    {
                        MessageBox.Show("Please fill in all required fields.");
                        return;
                    }

                    // Concatenate visitor details to be stored in QR code
                    string visitorData = $"Name: {firstName} {lastName}\nAddress: {address}\nContact: {contactNumber}\nPurpose: {purpose}";

                    GenerateQRCode(visitorData, firstName + lastName);  
                    MessageBox.Show("Visitor Registered Successfully!");
                    con.Close();
            }
            }

            private void GenerateQRCode(string data, string visitorID)
            {
                try
                {
                    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                    {
                        QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                        using (QRCode qrCode = new QRCode(qrCodeData))
                        {
                            Bitmap qrCodeImage = qrCode.GetGraphic(10);

                            // Display QR code in PictureBox
                            pictureBoxQR.Image = qrCodeImage;

                            // Save QR code as an image file
                            string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, $"Visitor_{visitorID}.png");
                            qrCodeImage.Save(filePath, ImageFormat.Png);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating QR Code: " + ex.Message);
                }
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                string recipientEmail = txtEmail.Text.Trim();

                // Validate email input
                if (string.IsNullOrEmpty(recipientEmail))
                {
                    MessageBox.Show("Please enter an email address.");
                    return;
                }

                if (!IsValidEmail(recipientEmail))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.");
                    return;
                }

                if (pictureBoxQR.Image == null)
                {
                    MessageBox.Show("No QR Code generated yet. Register first.");
                    return;
                }

                try
                {
                    // Save QR Code as a temporary file
                    string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "VisitorQR.png");
                    pictureBoxQR.Image.Save(filePath, ImageFormat.Png);

                    // Send Email with QR Code
                    bool emailSent = SendEmailWithQRCode(recipientEmail, filePath);
                    if (emailSent)
                    {
                        MessageBox.Show("QR Code sent successfully to " + recipientEmail);
                    }
                    else
                    {
                        MessageBox.Show("Failed to send QR Code.");
                    }

                    // Delete the QR Code file after sending
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
            private bool SendEmailWithQRCode(string recipientEmail, string qrFilePath)
            {
                try
                {
                    // Your email credentials
                    string senderEmail = "degolladomichael01@gmail.com";  // Replace with your email
                    string senderPassword = "ctor uogr wgin mvev";  // Use app password if needed

                    // Email setup
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Your Visitor QR Code";
                    mail.Body = "Dear Visitor,\n\nAttached is your generated QR Code for verification upon arrival.\n\nThank you!";

                    // Attach QR Code
                    Attachment attachment = new Attachment(qrFilePath);
                    mail.Attachments.Add(attachment);

                    // SMTP Client Configuration (Gmail example)
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential(senderEmail, senderPassword),
                        EnableSsl = true
                    };

                    // Send email
                    smtp.Send(mail);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email: " + ex.Message);
                    return false;
                }
            }

            private bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

        }
        }

