using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_Jogo
{
    class Acoes 
    {
        public int Life { get; set; }
        public int Monster { get; set; }
        public int Boss { get; set; }
        public int Porcoes { get; set; }
        public int Gun { get; set; }
        public int Atack { get; set; }
        public int Score { get; set; }

        public Acoes() : base()
        {
        }
       public Acoes(int Life, int DanoMonster, int Porcoes, int Gun, int DanoBoss, int Atack)
        {
            this.Life = Life;
            this.Monster = Monster;
            this.Boss = Boss;
            this.Porcoes = Porcoes;
            this.Gun = Gun;
            this.Atack = Atack;
        }

        public int DanoMonster(int danoMonster)
        {
           return this.Life -= danoMonster;
        }
        public int DanoBoss(int danoBoss)
        {
            return this.Life -= danoBoss;
        }
        public int RecuperaPorcoes(int recuperaPorcoes)
        {
            return this.Life += recuperaPorcoes;
        }
        public int GetGun(int getGun)
        {
            return this.Atack += getGun;
        }
        public int MonsterScore(int monsterScore)
        {
            return this.Score += monsterScore;
        }
        public int MonsterBoss(int monsterBoss)
        {
            return this.Score += monsterBoss;
        }

    }
}
