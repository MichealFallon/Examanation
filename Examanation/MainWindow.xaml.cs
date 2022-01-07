using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
/*
 * Micheal Fallon Examination 2021/2022 07/01/22
 * https://github.com/MichealFallon/Examanation Github Link
 */


namespace Examanation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Member> MemberList = new List<Member>();
        List<Member> SeniorMemberList = new List<Member>();
        List<Member> JuniorMemberList = new List<Member>();
        List<Member> RegularMemberList = new List<Member>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

            Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };
            
            MemberList.Add(jm1);
            MemberList.Add(jm2);
            MemberList.Add(jm3);

            MemberList.Add(m1);
            MemberList.Add(m2);
            MemberList.Add(m3);

            MemberList.Add(sm1);
            MemberList.Add(sm2);
            MemberList.Add(sm3);


            SeniorMemberList.Add(sm1);
            SeniorMemberList.Add(sm2);
            SeniorMemberList.Add(sm3);

            JuniorMemberList.Add(jm1);
            JuniorMemberList.Add(jm2);
            JuniorMemberList.Add(jm3);

            RegularMemberList.Add(m1);
            RegularMemberList.Add(m2);
            RegularMemberList.Add(m3);
            ltbxMembersList.ItemsSource = MemberList;
        }

        private void ltbxMembersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // setting the select activit to a varible we can use
            Member selcectedMember= ltbxMembersList.SelectedItem as Member;
            // checking to see if its null
            if (selcectedMember != null)
            {
                // setting the description box to have the right information
                
                
                tblkInfo.Text = selcectedMember.desc;
            }
        }

        private void rdJunior_Checked(object sender, RoutedEventArgs e)
        {
            ltbxMembersList.ItemsSource = null;
            ltbxMembersList.ItemsSource = JuniorMemberList;
            
        }

        private void rdSenior_Checked(object sender, RoutedEventArgs e)
        {
            ltbxMembersList.ItemsSource = null;
            ltbxMembersList.ItemsSource = SeniorMemberList;
        }

        private void rdAll_Checked(object sender, RoutedEventArgs e)
        {
            ltbxMembersList.ItemsSource = null;
            ltbxMembersList.ItemsSource = MemberList;
        }

        private void rdRegular_Checked(object sender, RoutedEventArgs e)
        {
            ltbxMembersList.ItemsSource = null;
            ltbxMembersList.ItemsSource = RegularMemberList;

        }
    }
}
