using System.Diagnostics;
using System;
using System.IO;
using System.Windows;

namespace Periode_2
{
    public partial class MainWindow : Window
    {
        private Window1 currentWindow1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowWindow1(int index)
        {
            DataElements.IndexEl = index;
            currentWindow1 = new Window1();
            currentWindow1.Closed += Window1_Closed;
            currentWindow1.Show();
        }

        private void Window1_Closed(object sender, System.EventArgs e)
        {
            // Activer MainWindow lorsque Window1 est fermée
            this.Activate();
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(0);
        }

        private void He_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(1);
        }

        private void Li_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(2);
        }

        private void Be_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(3);
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(4);
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(5);
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(6);
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(7);
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(8);
        }

        private void Ne_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(9);
        }

        private void Na_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(10);
        }

        private void Mg_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(11);
        }

        private void Al_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(12);
        }

        private void Si_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(13);
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(14);
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(15);
        }

        private void Cl_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(16);
        }

        private void Ar_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(17);
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(18);
        }

        private void Ca_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(19);
        }

        private void Sc_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(20);
        }

        private void Ti_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(21);
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(22);
        }

        private void Cr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(23);
        }

        private void Mn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(24);
        }

        private void Fe_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(25);
        }

        private void Co_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(26);
        }

        private void Ni_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(27);
        }

        private void Cu_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(28);
        }

        private void Zn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(29);
        }

        private void Ga_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(30);
        }

        private void Ge_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(31);
        }

        private void As_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(32);
        }

        private void Se_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(33);
        }

        private void Br_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(34);
        }

        private void Kr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(35);
        }

        private void Rb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(36);
        }

        private void Sr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(37);
        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(38);
        }

        private void Zr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(39);
        }

        private void Nb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(40);
        }

        private void Mo_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(41);
        }

        private void Tc_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(42);
        }

        private void Ru_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(43);
        }

        private void Rh_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(44);
        }

        private void Pd_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(45);
        }

        private void Ag_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(46);
        }

        private void Cd_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(47);
        }

        private void In_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(48);
        }

        private void Sn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(49);
        }

        private void Sb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(50);
        }

        private void Te_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(51);
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(52);
        }

        private void Xe_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(53);
        }

        private void Cs_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(54);
        }

        private void Ba_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(55);
        }

        private void La_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(56);
        }

        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(57);
        }

        private void Pr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(58);
        }

        private void Nd_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(59);
        }

        private void Pm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(60);
        }

        private void Sm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(61);
        }

        private void Eu_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(62);
        }

        private void Gd_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(63);
        }

        private void Tb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(64);
        }

        private void Dy_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(65);
        }

        private void Ho_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(66);
        }

        private void Er_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(67);
        }

        private void Tm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(68);
        }

        private void Yb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(69);
        }

        private void Lu_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(70);
        }

        private void Hf_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(71);
        }

        private void Ta_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(72);
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(73);
        }

        private void Re_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(74);
        }

        private void Os_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(75);
        }

        private void Ir_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(76);
        }

        private void Pt_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(77);
        }

        private void Au_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(78);
        }

        private void Hg_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(79);
        }

        private void Tl_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(80);
        }

        private void Pb_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(81);
        }

        private void Bi_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(82);
        }

        private void Po_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(83);
        }

        private void At_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(84);
        }

        private void Rn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(85);
        }

        private void Fr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(86);
        }

        private void Ra_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(87);
        }

        private void Ac_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(88);
        }

        private void Th_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(89);
        }

        private void Pa_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(90);
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(91);
        }

        private void Np_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(92);
        }

        private void Pu_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(93);
        }

        private void Am_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(94);
        }

        private void Cm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(95);
        }

        private void Bk_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(96);
        }

        private void Cf_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(97);
        }

        private void Es_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(98);
        }

        private void Fm_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(99);
        }

        private void Md_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(100);
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(101);
        }

        private void Lr_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(102);
        }

        private void Rf_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(103);
        }

        private void Db_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(104);
        }

        private void Sg_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(105);
        }

        private void Bh_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(106);
        }

        private void Hs_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(107);
        }

        private void Mt_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(108);
        }

        private void Ds_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(109);
        }

        private void Rg_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(110);
        }

        private void Cn_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(111);
        }

        private void Nh_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(112);
        }

        private void Fl_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(113);
        }

        private void Mc_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(114);
        }

        private void Lv_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(115);
        }

        private void Ts_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(116);
        }

        private void Og_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow1(117);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void About(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }
        private void GitHub(object sender, RoutedEventArgs e)
        {
            OpenUrl("https://github.com/FranciumSoftware");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture de l'URL : {ex.Message}");
            }
        }
    }
}
