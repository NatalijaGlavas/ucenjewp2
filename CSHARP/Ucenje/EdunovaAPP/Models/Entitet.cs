using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    /// <summary>
    /// Ovo je vršna nad klasa koja služiza osnovne atribute
    /// tipa sifra, operater, datum unosa, promjene itd.
    /// </summary>
    public abstract class Entitet
    {
        /// <summary>
        /// Ovo svojstvo mi služi kao primarni kljuć u bas s 
        /// generiranjem vrijednosti indetiti(1,1)
        /// </summary>
        [Key]
        public int Sifra { get; set; }

    }
}
