using NUnit.Framework;
using System.Net;
using Microsoft.Win32;
using System.Windows.Forms;

namespace App_windows.Tests
{
    [TestFixture]
    public class Form1Tests
    {
        private Form1 form;

        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

        [Test]
        public void ObtenirAdresseIP_DoitRetournerUneAdresseValide()
        {
            string ip = form.ObtenirAdresseIP();

            Assert.That(string.IsNullOrEmpty(ip), Is.False);
            Assert.DoesNotThrow(() => IPAddress.Parse(ip));
        }

        [Test]
        public void AjouterAuDemarrage_CreerCheminCorrect()
        {
            form.AjouterAuDemarrage();

            var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false);
            string exePath = Application.ExecutablePath;
            string value = key?.GetValue("MonApplication") as string;

            Assert.That(value, Is.Not.Null);
            Assert.That(value, Is.EqualTo($"\"{exePath}\" --silent"));
        }
    }
}
