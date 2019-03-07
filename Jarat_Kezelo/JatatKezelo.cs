using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarat_Kezelo
{
    public class JatatKezelo
    {
        public class Jarat
        {
            public string jaratSzam { get; set; }
            public string repterHonnan { get; set; }
            public string repterHova { get; set; }
            public DateTime indulas { get; set; }
            public int keses { get; set; }

            public Jarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                this.jaratSzam = jaratSzam;
                this.repterHonnan = repterHonnan;
                this.repterHova = repterHova;
                this.indulas = indulas;
                keses = 0;
            }

        }
            List<Jarat> jaratok_osszes = new List<Jarat>();

            public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {
                foreach (Jarat sz in jaratok_osszes)
                {
                    if (sz.jaratSzam.Contains(jaratSzam))
                    {
                        throw new ArgumentException("Létező járat!!!");
                    }
                }
                jaratok_osszes.Add(new Jarat(jaratSzam, repterHonnan, repterHova, indulas));
            }

            public void Keses(string jaratSzam, int keses)
            {
                foreach (Jarat sz in jaratok_osszes)
                {
                    if (sz.jaratSzam.Equals(jaratSzam))
                    {
                        if (keses < 0)
                        {
                            if (sz.keses + keses < 0)
                            {
                                throw new HibasJaratExection(sz.keses + keses);
                            }
                        }
                        else
                        {
                            sz.keses += keses;
                        }
                    }
                }
            }

            public DateTime MikorIndul(string jaratSzam)
            {
                foreach (Jarat sz in jaratok_osszes)
                {
                    if (sz.jaratSzam.Equals(jaratSzam))
                    {
                        DateTime pontosindulas = sz.indulas.AddMinutes(sz.keses);
                        return pontosindulas;
                    }
                    else
                    {
                    }
                }
                throw new ArgumentException("Hibás járatszám");
            }

            public List<string> JaratokRepuloterrol(string repter)
            {
                List<string> jaratokinnen = new List<string>();
                foreach (Jarat sz in jaratok_osszes)
                {
                    if (sz.repterHonnan.Equals(repter))
                    {
                        jaratokinnen.Add(sz.jaratSzam);
                    }
                }
                return jaratokinnen;
            }

        
    }
}


