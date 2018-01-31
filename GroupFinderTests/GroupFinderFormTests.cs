using System.Windows.Forms;
using Domain_Group_Finder;
using NUnit.Framework;

namespace GroupFinderTests
{
    [TestFixture]
    public class GroupFinderFormTests
    {

        [Test]
        public void CreateGroupFinderForm()
        {
            var form = new MainForm();
            form.Show();

            Assert.IsNotNull( form._controller );
            Assert.AreEqual( form.Text, "Network Group Finder");
            Assert.AreEqual( form.stsVersion.Text, string.Format("Ver. {0}",Application.ProductVersion));
        }
    }
}
