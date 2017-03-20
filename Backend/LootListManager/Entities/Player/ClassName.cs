using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LootListManager.Entities.Player {
    public class ClassName {
        public virtual int ClassNameId { get; set; }
        public virtual Class ClassRef { get; set; }
        public virtual string ClassNameCulture { get; set; }
        public virtual string ClassNameString { get; set; }
    }
}

/*

ClassRaceSettings
- ClassRaceSettingId
- FK_ClassId
- FK_RaceId

FactionNames
- FactionNameId
- FK_FactionId
- FactionNameCulture
- FactionNameString

Factions
- FactionId
- FactionImage

InstanceNames
- InstanceNameId
- FK_InstanceId
- InstanceNameCulture
- InstanceNameString

Instances
- InstanceId
- InstanceSort
- InstanceImage

ItemBossSettings
- ItemBossSettingId
- FK_ItemId
- FK_BossId

ItemNames
- ItemNameId
- FK_ItemId
- ItemNameCulture
- ItemNameString

Items
- ItemId
- ItemImage

Needs
- NeedId
- FK_CharacterId
- FK_ItemId
- FK_NeedTypeId
- FK_PriorityId

NeedTypes
- NeedTypeId
- NeedTypeName

Priorities
- PriorityId
- PriorityName

RaceNames
- RaceNameId
- FK_RaceId
- RaceNameCulture
- RaceNameString

Races
- RaceId
- FK_FactionId
- RaceImage

TalentNames
- TalentNameId
- FK_TalentId
- TalentNameCulture
- TalentNameString

Talents
- TalentId
- FK_ClassId
- TalentImage

Tokens
- TokenId
- FK_UserId
- AuthToken
- IssuedOn
- ExpiresOn

Users
- UserId
- UserName
- UserPasswordHash
- UserLoginAttempts

    */
