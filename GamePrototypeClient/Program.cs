﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.user;
using GamePrototypeClient.GamePrototypeServiceReference;

namespace GamePrototypeClient
{
    static class Program
    {
        // <summary>
        // The main entry point for the application.
        // </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameForm());

            //var clientService = new GamePrototypeServiceClient();

            //CharacterWarehouse warehouse = new CharacterWarehouse {Value = 0};

            //Character testCharacter = new Character()
            //{
            //    Name = "Rop",
            //    Agility = 1,
            //    Attack = 1,
            //    Defense = 1,
            //    Health = 1,
            //    Mana = 1,
            //    Intelligence = 1,
            //    Level = 1,
            //    MagicAttack = 1,
            //    MagicDefence = 1,
            //    CharacterWarehouse = warehouse,
            //    CharacterEquipment = new CharacterEquipment(),
            //    CharacterType = CharacterTypeEnum.Assassin,
            //    ImageUrl = "asdsad"
            //};

            //clientService.SetCharacter(testCharacter);

            //var testUser = new UserProfile()
            //{
            //    UserCharacter = testCharacter,
            //    UserSex = UserSexEnum.Male,
            //    Name = "Tomi",
            //    Age = 18,
            //    EMail = "asd@a.ru",
            //    LastName = "Lol",
            //    Login = "qqq",
            //    Password = "qwerty",
            //    PhoneNumber = "555-555-555"
            //};

            //clientService.SetUserProfile(testUser);
        }
    }
}
