using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Java_Proje
{
    static class HataMesajlari
    {
        public static void KumbaraDolu() { MessageBox.Show("Kumbara DOLU !!"); }
        public static void Yapistirilamaz() { MessageBox.Show("Kumbara daha önce yapıştırıldı Tekrar Kullanılamaz.."); }
        public static void KumbaraZatenKirik() { MessageBox.Show("Kumbara Zaten Kırık Önce Yapıştır"); }
        public static void OnceKumbarayiKir() { MessageBox.Show("Önce Kumbarayı Kır !!1"); }

    }
}
