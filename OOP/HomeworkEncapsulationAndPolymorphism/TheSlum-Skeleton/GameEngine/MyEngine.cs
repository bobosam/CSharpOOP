namespace TheSlum.GameEngine
{
    using System;
    using TheSlum.Characters;
    using TheSlum.Items;
    using TheSlum.Items.Bonuses;

    public class MyEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0].ToLower())
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            Character character = GetCharacterById(inputParams[1]);
            Item item;

            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    character.AddToInventory(item);
                    break;
                default:
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            int x;
            int y;
            Team team;
            Character character;
            switch (inputParams[1].ToLower())
            {
                case "mage":
                    x = int.Parse(inputParams[3]);
                    y = int.Parse(inputParams[4]);
                    team = (Team)Enum.Parse(typeof(Team), inputParams[5], true);
                    character = new Mage(inputParams[2], x, y, team);
                    this.characterList.Add(character);
                    break;
                case "warrior":
                    x = int.Parse(inputParams[3]);
                    y = int.Parse(inputParams[4]);
                    team = (Team)Enum.Parse(typeof(Team), inputParams[5], true);
                    character = new Warrior(inputParams[2], x, y, team);
                    this.characterList.Add(character);
                    break;
                case "healer":
                    x = int.Parse(inputParams[3]);
                    y = int.Parse(inputParams[4]);
                    team = (Team)Enum.Parse(typeof(Team), inputParams[5], true);
                    character = new Healer(inputParams[2], x, y, team);
                    this.characterList.Add(character);
                    break;
            }
        }
    }
}
