using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];

        }

        

        //Metodos
        public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            this.meleeCards[PlayerId].Add(combatCard);
           
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            this.rangeCards[PlayerId].Add(combatCard);
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            this.longRangeCards[PlayerId].Add(combatCard);
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            this.captainCards[PlayerId]=specialCard;
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            this.weatherCards[PlayerId]=specialCard;
        }
        public void DestroyMeleeCard(int PlayerId)
        {
            this.meleeCards[PlayerId].Clear();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            this.rangeCards[PlayerId].Clear();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            this.longRangeCards[PlayerId].Clear();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            Array.Clear(this.specialMeleeCards, 0, this.specialMeleeCards.Length);
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            Array.Clear(this.specialRangeCards,0,this.specialRangeCards.Length);
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            Array.Clear(this.specialLongRangeCards, 0, this.specialLongRangeCards.Length);
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            this.weatherCards.Clear();
        }
        public void AddCombatCard(int Playerid,CombatCard combatCard)
        {
            if (combatCard.Type == "melee")
            {
                this.AddMeleeCard(Playerid, combatCard);
            }
            if(combatCard.Type == "range"){
                this.AddRangeCard(Playerid, combatCard);
            }
            if(combatCard.Type == "LongRange")
            {
                this.AddLongRangeCard(Playerid, combatCard);
            }


        }
        public void AddSpecialCard(int Playerid,SpecialCard specialCard,string Bufftype)
        {
            if (Bufftype != null)
            {
                throw new NotImplementedException();
            }
            if (Playerid == 0)
            {
                throw new NotImplementedException();
            }
            if (specialCard.Type == "Weather")
            {
                this.AddWeatherCard(Playerid, specialCard);
            }
            if (specialCard.Type == "Captain")
            {
                if(this.captainCards[Playerid]!= null)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    this.AddCaptainCard(Playerid, specialCard);
                }
            }
        }
        public void DestroyCombatCard(int Playerid)
        {
            if (this.meleeCards[Playerid] != null)
            {
                this.DestroyMeleeCard(Playerid);
            }
            if (this.rangeCards[Playerid] != null)
            {
                this.DestroyRangeCard(Playerid);
            }
            if (this.longRangeCards[Playerid] != null)
            {
                this.DestroyLongRangeCard(Playerid);
            }

        }
        public void DestroySpecialCards(int Playerid)
        {
            if(this.specialMeleeCards[Playerid] != null)
            {
                this.DestroySpecialMeleeCard(Playerid);
            }
            if (this.specialRangeCards[Playerid] != null)
            {
                this.DestroySpecialRangeCard(Playerid);
            }
            if (this.specialLongRangeCards[Playerid] != null)
            {
                this.DestroySpecialLongRangeCard(Playerid);
            }
            if (this.weatherCards[Playerid] != null)
            {
                this.DestroyWeatherCard(Playerid);
            }
        }


        public int[] GetMeleeAttackPoints()
        {
            int k;
            int s;
            int[] p = new int[2];
            p[0]=0;
            p[1]=0;
            for(k=0;k<2;k++)
            {
              int j = this.meleeCards[k].Count;
              for (s=0; s<=j;s++)
              {
              p[k]= p[k] + this.meleeCards[k][s].AttackPoints;

              }
            }
            
            return p;
        }
        public int[] GetRangeAttackPoints()
        {
            int k;
            int s;
            int[] p = new int[2];
            p[0] = 0;
            p[1] = 0;
            for (k = 0; k < 2; k++)
            {
                int j = this.rangeCards[k].Count;
                for (s = 0; s <= j; s++)
                {
                    p[k] = p[k] + this.rangeCards[k][s].AttackPoints;

                }
            }

            return p;
        }
        public int[] GetLongRangeAttackPoints()
        {
            int k;
            int s;
            int[] p = new int[2];
            p[0] = 0;
            p[1] = 0;
            for (k = 0; k < 2; k++)
            {
                int j = this.longRangeCards[k].Count;
                for (s = 0; s <= j; s++)
                {
                    p[k] = p[k] + this.longRangeCards[k][s].AttackPoints;

                }
            }

            return p;
        }
    }
}
