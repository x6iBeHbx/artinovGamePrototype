using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GamePrototypeClasses.enums;
using GamePrototypeClasses.game.character;
using GamePrototypeClasses.game.character.warehouse;
using GamePrototypeClasses.game.thinks;
using GamePrototypeClasses.user;

namespace GamePrototypeWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGamePrototypeService" in both code and config file together.
    [ServiceContract]
    public interface IGamePrototypeService
    {
        //--------GET----------
        //User 
        [OperationContract]
        List<UserProfile> GetAllUsers();
        //[OperationContract]
        //UserProfile GetUserByLogin(string login);
        //[OperationContract]
        //UserProfile GetUserByEMail(string email);
        //[OperationContract]
        //UserProfile GetUSerByPhone(string phone);
        [OperationContract]
        UserProfile GetUserByCharactrId(Guid id);
        [OperationContract]
        UserProfile GetUserByCharactr(Character character);
        [OperationContract]
        string GetUserPassByUserId(Guid id);
        [OperationContract]
        string GetUserPassByUserLogin(string login);

        //Character
        [OperationContract]
        List<Character> GetAllCharacters();
        [OperationContract]
        List<Character> GetAllCharactersByType(CharacterTypeEnum characterType);
        [OperationContract]
        Character GetCharacterId(Guid id);
        [OperationContract]
        Character GetCharacterByUser(UserProfile user);
        [OperationContract]
        Character GetCharacterByNickName(string nickName);
        //[OperationContract]
        //Character GetCharacterByWarehouse(CharacterWarehouse warehouse);
        //[OperationContract]
        //Character GetCharacterByQuipment(CharacterEquipment eqiupment);

        //warehose
        [OperationContract]
        List<CharacterWarehouse> GetAllWarehouse();
        [OperationContract]
        List<CharacterWarehouse> GetAllCharacterWarehousesByThing(Things thing);
        [OperationContract]
        List<CharacterWarehouse> GetAllCharacterWarehousesByScroll(Scrolls scroll);
        [OperationContract]
        List<CharacterWarehouse> GetAllCharacterWarehousesByPotion(Potions potion);
        [OperationContract]
        CharacterWarehouse GetWarehouseById(Guid id);
        //CharacterWarehouse GetWarehouseByUser(UserProfile user);
        
        //character things, scrolls, potions
        [OperationContract]
        List<CharacterThings> GetAllCharacterThingsByWarehouse(CharacterWarehouse warehouse);
        [OperationContract]
        List<CharacterSrolls> GetAllCaharacterSrollsByWarehouse(CharacterWarehouse warehouse);
        [OperationContract]
        List<CharacterPotions> GerAllCharacterPotionsByWarehouse(CharacterWarehouse warehouse);
        [OperationContract]
        CharacterThings GetWarehouseThingById(Guid id);
        [OperationContract]
        CharacterSrolls GetWarehouseScrollById(Guid id);
        [OperationContract]
        CharacterPotions GetWarehousePotionById(Guid id);
        
        //Things
        [OperationContract]
        List<Things> GetAllThings();
        [OperationContract]
        List<Things> GetAllThingsByThingType(ThingsTypeEnum thingType);
        [OperationContract]
        Things GetThingById(Guid id);
        [OperationContract]
        int GetThingPrice(Things thing);

        //Scroll
        [OperationContract]
        List<Scrolls> GetAllScrolls();
        [OperationContract]
        List<Scrolls> GetAllScrollsByThingType(ThingsTypeEnum thingType);
        [OperationContract]
        Scrolls GetScrollById(Guid id);
        [OperationContract]
        int GetScrollPrice(Scrolls scroll);

        //Potion
        [OperationContract]
        List<Potions> GetAllPotions();
        [OperationContract]
        List<Potions> GetAllPotionsByThingType(ThingsTypeEnum thingType);
        [OperationContract]
        Potions GetPotionById(Guid id);
        [OperationContract]
        int GetPotionPrice(Potions potions);

        //Spacial thing type
        [OperationContract]
        List<SpecialThingBonus> GetAllSpecialThingBonuses();
        //TODO: need continue create this class

        //--------SET----------

        //user profile
        void SetUserProfile(UserProfile userProfile);
        void UpdateUserProfile(UserProfile userProfile);
        //character
        void SetCharacter(Character character);
    }
}
