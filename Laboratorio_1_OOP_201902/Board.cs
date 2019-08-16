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
            this.captainCards[PlayerId].Add(specialCard);
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            this.weatherCards[PlayerId].Add(specialCard);
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
            this.specialMeleeCards[PlayerId].Clear();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            this.specialRangeCards[PlayerId].Clear();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            this.specialLongRangeCards[PlayerId].Clear();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            this.weatherCards[PlayerId].Clear();
        }
        public int[] GetMeleeAttackPoints()
        {
            int k = 0;
            int[] p = new int[2];
            while (k<2)
            {
                p[k] = meleeCards[k];
            }
            return p;
        }
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
