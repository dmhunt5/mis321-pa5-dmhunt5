namespace mis321_pa5_dmhunt5
{
    public class Character
    {
        public string PlayerName {get;set;}
        public int MaxPower {get;set;}
        public int Health = 100;
        public int AttackStrength {get;set;}
        public int DefensePower {get;set;}
        public IAttack CharacterAttack {get;set;}
        public ISpecial CharacterSpecial {get;set;}
        public void SetCharacterAttack(IAttack attack)
        {
            CharacterAttack = attack;
        }
        public void SetCharacterSpecial(ISpecial special)
        {
            CharacterSpecial = special;
        }

        public override string ToString()
        {
            return $"{MaxPower}, {Health}, {AttackStrength}, {DefensePower}";
        }
    }
}