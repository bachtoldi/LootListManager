-- Instances

SET IDENTITY_INSERT [LootListManager].[dbo].[Instances] ON

INSERT INTO [LootListManager].[dbo].[Instances] ( [InstanceId], [InstanceSort] ) VALUES
(1, 1), 
(2, 2), 
(3, 3), 
(4, 4), 
(5, 5), 
(6, 6), 
(7, 7), 
(8, 8)

SET IDENTITY_INSERT [LootListManager].[dbo].[Instances] OFF

GO

-- InstanceNames
INSERT INTO [LootListManager].[dbo].[InstanceNames] ( [FK_InstanceId], [InstanceNameCulture], [InstanceNameString] ) VALUES
(1,		'de',	'Onyxias Hort'),			(1,		'en',	'Onyxia''s Lair'),
(2,		'de',	'Geschmolzener Kern'),		(2,		'en',	'Molten Core'),
(3,		'de',	'Zul''Gurub'),				(3,		'en',	'Zul''Gurub'),
(4,		'de',	'Pechschwingenhort'),		(4,		'en',	'Blackwinglair'),
(5,		'de',	'Ruinen von Ahn''Qiraj'),	(5,		'en',	'Ruins of Ahn''Qiraj'),
(6,		'de',	'Tempel von Ahn''Qiraj'),	(6,		'en',	'Temple of Ahn''Qiraj'),
(7,		'de',	'Naxxramas'),				(7,		'en',	'Naxxramas'),
(8,		'de',	'Weltbosse'),				(8,		'en',	'World Bosses')

GO

-- Bosses

SET IDENTITY_INSERT [LootListManager].[dbo].[Bosses] ON

INSERT INTO [LootListManager].[dbo].[Bosses] ( [BossId], [BossSort], [FK_InstanceId] ) VALUES
(1,		1,		1),

(2,		1,		2),
(3,		2,		2),
(4,		3,		2),
(5,		4, 2),
(6,		5, 2),
(7,		6, 2),
(8,		7, 2),
(9,		8, 2),
(10,	9, 2),
(11,	10,2),
(12,	11,2),

(13,	1, 3),
(14,	2, 3),
(15,	3, 3),
(16,	4, 3),
(17,	5, 3),
(18,	6, 3),
(19,	7, 3),
(20,	8, 3),
(21,	9, 3),
(22,	10,3),
(23,	11,3),

(24,	1, 4),
(25,	2, 4),
(26,	3, 4),
(27,	4, 4),
(28,	5, 4),
(29,	6, 4),
(30,	7, 4),
(31,	8, 4),
(32,	9, 4),

(33,	1, 5),
(34,	2, 5),
(35,	3, 5),
(36,	4, 5),
(37,	5, 5),
(38,	6, 5),
(39,	7, 5),

(40,	1, 6),
(41,	2, 6),
(42,	3, 6),
(43,	4, 6),
(44,	5, 6),
(45,	6, 6),
(46,	7, 6),
(47,	8, 6),
(48,	9, 6),
(49,	10,6),

(50,	1, 7),
(51,	2, 7),
(52,	3, 7),
(53,	4, 7),
(54,	5, 7),
(55,	6, 7),
(56,	7, 7),
(57,	8, 7),
(58,	9, 7),
(59,	10,7),
(60,	11,7),
(61,	12,7),
(62,	13,7),
(63,	14,7),
(64,	15,7),
(65,	16,7),

(66,	1, 8),
(67,	2, 8),
(68,	3, 8),
(69,	4, 8),
(70,	5, 8),
(71,	6, 8)

SET IDENTITY_INSERT [LootListManager].[dbo].[Bosses] OFF

GO

-- BossNames

INSERT INTO [LootListManager].[dbo].[BossNames] ( [FK_BossId], [BossNameCulture], [BossNameString] ) VALUES
(1,		'de',	'Onyxia'),						(1, 'en', 'Onyxia'),

(2,		'de',	'Lucifron'),					(2,		'en',	'Lucifron'),
(3,		'de',	'Magmadar'),					(3,		'en',	'Magmadar'),
(4,		'de',	'Gehennas'),					(4,		'en',	'Gehennas'),
(5,		'de',	'Garr'),						(5,		'en',	'Garr'),
(6,		'de',	'Shazzrah'),					(6,		'en',	'Shazzrah'),
(7,		'de',	'Baron Geddon'),				(7,		'en',	'Baron Geddon'),
(8,		'de',	'Sulfuronherold'),				(8,		'en',	'Sulfuron Herold'),
(9,		'de',	'Golemagg der Verbrenner'),		(9,		'en',	'Golemagg the Incinerator'),
(10,	'de',	'Majordomus Exekutus'),			(10,	'en',	'Majordomo Executus'),
(11,	'de',	'Ragnaros'),					(11,	'en',	'Ragnaros'),
(12,	'de',	'Trash'),						(12,	'en',	'Trash'),

(13,	'de',	'Hohepriesterin Jeklik'),		(13,	'en',	'High Priestess Jeklik'),
(14,	'de',	'Hohepriester Venoxis'),		(14,	'en',	'High Priest Venoxis'),
(15,	'de',	'Hohepriesterin Mar''li'),		(15,	'en',	'High Priestess Mar''li'),
(16,	'de',	'Hohepriester Thekal'),			(16,	'en',	'High Priest Thekal'),
(17,	'de',	'Hohepriesterin Arlokk'),		(17,	'en',	'High Priestess Arlokk'),
(18,	'de',	'Blutfürst Mandokir'),			(18,	'en',	'Bloodlord Mandokir'),
(19,	'de',	'Jin''do der Verhexer'),		(19,	'en',	'Jin''do the Hexxer'),
(20,	'de',	'Gahz''ranka'),					(20,	'en',	'Gahz''ranka'),
(21,	'de',	'Hort des Wahnsinns'),			(21,	'en',	'Edge of Madness'),
(22,	'de',	'Hakkar'),						(22,	'en',	'Hakkar'),
(23,	'de',	'Trash'),						(23,	'en',	'Trash'),

(24,	'de',	'Feuerkralle der Ungezähmte'),	(24,	'en',	'Razorgore the Untamed'),
(25,	'de',	'Vaelastrasz'),					(25,	'en',	'Vaelastrasz the Corrupt'),
(26,	'de',	'Brutwächter Dreschbringer'),	(26,	'en',	'Broodlord Lashlayer'),
(27,	'de',	'Feuerschwinge'),				(27,	'en',	'Flamegor'),
(28,	'de',	'Schattenschwinge'),			(28,	'en',	'Ebonroc'),
(29,	'de',	'Flammenmaul'),					(29,	'en',	'Firemaw'),
(30,	'de',	'Chromagus'),					(30,	'en',	'Chromaggus'),
(31,	'de',	'Nefarian'),					(31,	'en',	'Nefarian'),
(32,	'de',	'Trash'),						(32,	'en',	'Trash'),

(33,	'de',	'Kurinaxx'),					(33,	'en',	'Kurinaxx'),
(34,	'de',	'General Rajaxx'),				(34,	'en',	'General Rajaxx'),
(35,	'de',	'Moam'),						(35,	'en',	'Moam'),
(36,	'de',	'Buru der Verschlinger'),		(36,	'en',	'Buru the Gorger'),
(37,	'de',	'Ayamiss der Jäger'),			(37,	'en',	'Ayamiss the Hunter'),
(38,	'de',	'Ossirian der Narbenlose'),		(38,	'en',	'Ossirian the Unscarred'),
(39,	'de',	'Trash'),						(39,	'en',	'Trash'),

(40,	'de',	'Der Prophet Skeram'),			(40,	'en',	'The Prophet Skeram'),
(41,	'de',	'Adel der Silithiden'),			(41,	'en',	'Silithid Royalty'),
(42,	'de',	'Schlachtwache Sartura'),		(42,	'en',	'Battleguard Sartura'),
(43,	'de',	'Fankriss der Unnachgiebige'),	(43,	'en',	'Fankriss the Unyielding'),
(44,	'de',	'Viscidus'),					(44,	'en',	'Viscidus'),
(45,	'de',	'Prinzessin Huhuran'),			(45,	'en',	'Princess Huhuran'),
(46,	'de',	'Zwilingsimperatoren'),			(46,	'en',	'The Twin Emperors'),
(47,	'de',	'Ouro'),						(47,	'en',	'Ouro'),
(48,	'de',	'C''Thun'),						(48,	'en',	'C''Thun'),
(49,	'de',	'Trash'),						(49,	'en',	'Trash'),

(50,	'de',	'Anub''Rekhan'),				(50,	'en',	'Anub''Rekhan'),
(51,	'de',	'Großwitwe Faerlina'),			(51,	'en',	'Grand Widow Faerlina'),
(52,	'de',	'Maexxna'),						(52,	'en',	'Maexxna'),
(53,	'de',	'Noth der Seuchenfürst'),		(53,	'en',	'Noth the Plaguebringer'),
(54,	'de',	'Heighan der Unreine'),			(54,	'en',	'Heigan the Unclean'),
(55,	'de',	'Loatheb'),						(55,	'en',	'Loatheb'),
(56,	'de',	'Instrukteur Razuvious'),		(56,	'en',	'Instructor Razuvious'),
(57,	'de',	'Gothik der Seelenjäger'),		(57,	'en',	'Gothik the Harvester'),
(58,	'de',	'Die vier Reiter'),				(58,	'en',	'The Four Horsemen'),
(59,	'de',	'Flickwerk'),					(59,	'en',	'Patchwork'),
(60,	'de',	'Grobbulus'),					(60,	'en',	'Grobbulus'),
(61,	'de',	'Gluth'),						(61,	'en',	'Gluth'),
(62,	'de',	'Thaddius'),					(62,	'en',	'Thaddius'),
(63,	'de',	'Saphiron'),					(63,	'en',	'Sapphiron'),
(64,	'de',	'Kel''Thuzad'),					(64,	'en',	'Kel''Thuzad'),
(65,	'de',	'Trash'),						(65,	'en',	'Trash'),

(66,	'de',	'Kazzak'),						(66,	'en',	'Kazzak'),
(67,	'de',	'Azuregos'),					(67,	'en',	'Azuregos'),
(68,	'de',	'Ysondre'),						(68,	'en',	'Ysondre'),
(69,	'de',	'Lethon'),						(69,	'en',	'Lethon'),
(70,	'de',	'Taerar'),						(70,	'en',	'Taerar'),
(71,	'de',	'Emeriss'),						(71,	'en',	'Emeriss')

GO

-- Classes

SET IDENTITY_INSERT [LootListManager].[dbo].[Classes] ON

INSERT INTO [LootListManager].[dbo].[Classes] ( [ClassId] ) VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9)

SET IDENTITY_INSERT [LootListManager].[dbo].[Classes] OFF

GO

-- ClassNames

INSERT INTO [LootListManager].[dbo].[ClassNames] ( [FK_ClassId], [ClassNameCulture], [ClassNameString] ) VALUES
(1,		'de',	'Priester'),		(1,		'en',	'Priest'),
(2,		'de',	'Magier'),			(2,		'en',	'Mage'),
(3,		'de',	'Hexenmeister'),	(3,		'en',	'Warlock'),
(4,		'de',	'Schurke'),			(4,		'en',	'Rogue'),
(5,		'de',	'Druide'),			(5,		'en',	'Druid'),
(6,		'de',	'Jäger'),			(6,		'en',	'Hunter'),
(7,		'de',	'Schamane'),		(7,		'en',	'Shaman'),
(8,		'de',	'Krieger'),			(8,		'en',	'Warrior'),
(9,		'de',	'Paladin'),			(9,		'en',	'Paladin')

GO

-- Talents

SET IDENTITY_INSERT [LootListManager].[dbo].[Talents] ON

INSERT INTO [LootListManager].[dbo].[Talents] ( [TalentId], [FK_ClassId] ) VALUES
(1,		1),
(2,		1),
(3,		1),

(4,		2),
(5,		2),
(6,		2),

(7,		3),
(8,		3),
(9,		3),

(10,	4),
(11,	4),
(12,	4),

(13,	5),
(14,	5),
(15,	5),

(16,	6),
(17,	6),
(18,	6),

(19,	7),
(20,	7),
(21,	7),

(22,	8),
(23,	8),
(24,	8),

(25,	9),
(26,	9),
(27,	9)

SET IDENTITY_INSERT [LootListManager].[dbo].[Talents] OFF

GO

-- TalentNames

INSERT INTO [LootListManager].[dbo].[TalentNames] ( [FK_TalentId], [TalentNameCulture], [TalentNameString] ) VALUES
(1,		'de',	'Heilig'),				(1,		'en',	'Holy'),
(2,		'de',	'Disziplin'),			(2,		'en',	'Discipline'),
(3,		'de',	'Schatten'),			(3,		'en',	'Shadow'),

(4,		'de',	'Frost'),				(4,		'en',	'Frost'),
(5,		'de',	'Feuer'),				(5,		'en',	'Fire'),
(6,		'de',	'Arkan'),				(6,		'en',	'Arcane'),

(7,		'de',	'Gebrechen'),			(7,		'en',	'Affliction'),
(8,		'de',	'Zerstörung'),			(8,		'en',	'Descruction'),
(9,		'de',	'Dämonologie'),			(9,		'en',	'Demonology'),

(10,	'de',	'Kampf'),				(10,	'en',	'Combat'),
(11,	'de',	'Täuschung'),			(11,	'en',	'Subtlety'),
(12,	'de',	'Meucheln'),			(12,	'en',	'Assassination'),

(13,	'de',	'Wilder Kampf'),		(13,	'en',	'Feral'),
(14,	'de',	'Gleichgewicht'),		(14,	'en',	'Balance'),
(15,	'de',	'Wiederherstellung'),	(15,	'en',	'Restoration'),

(16,	'de',	'Überleben'),			(16,	'en',	'Survival'),
(17,	'de',	'Treffsicherheit'),		(17,	'en',	'Marksmanship'),
(18,	'de',	'Tierherrschaft'),		(18,	'en',	'Beast Mastery'),

(19,	'de',	'Wiederherstellung'),	(19,	'en',	'Restoration'),
(20,	'de',	'Verstärkung'),			(20,	'en',	'Enhancement'),
(21,	'de',	'Elementar'),			(21,	'en',	'Elemental'),

(22,	'de',	'Schutz'),				(22,	'en',	'Protection'),
(23,	'de',	'Waffen'),				(23,	'en',	'Arms'),
(24,	'de',	'Furor'),				(24,	'en',	'Fury'),

(25,	'de',	'Heilig'),				(25,	'en',	'Holy'),
(26,	'de',	'Schutz'),				(26,	'en',	'Protection'),
(27,	'de',	'Vergeltung'),			(27,	'en',	'Retribution')

GO

-- Factions

SET IDENTITY_INSERT [LootListManager].[dbo].[Factions] ON

INSERT INTO [LootListManager].[dbo].[Factions] ( [FactionId] ) VALUES
(1),
(2)

SET IDENTITY_INSERT [LootListManager].[dbo].[Factions] OFF

GO

-- FactionNames

INSERT INTO [LootListManager].[dbo].[FactionNames] ( [FK_FactionId], [FactionNameCulture], [FactionNameString] ) VALUES
(1,		'de',	'Allianz'),		(1,		'en',	'Alliance'),
(2,		'de',	'Horde'),		(2,		'en',	'Horde')

GO

-- Races

SET IDENTITY_INSERT [LootListManager].[dbo].[Races] ON

INSERT INTO [LootListManager].[dbo].[Races] ( [RaceId], [FK_FactionId] ) VALUES
(1,		1),
(2,		1),
(3,		1),
(4,		1),
(5,		2),
(6,		2),
(7,		2),
(8,		2)

SET IDENTITY_INSERT [LootListManager].[dbo].[Races] OFF

GO

-- RaceNames

INSERT INTO [LootListManager].[dbo].[RaceNames] ( [FK_RaceId], [RaceNameCulture], [RaceNameString] ) VALUES
(1,		'de',	'Gnom'),		(1,		'en',	'Gnome'),
(2,		'de',	'Zwerg'),		(2,		'en',	'Dwarf'),
(3,		'de',	'Mensch'),		(3,		'en',	'Human'),
(4,		'de',	'Nachtelf'),	(4,		'en',	'Nightelf'),
(5,		'de',	'Untot'),		(5,		'en',	'Undead'),
(6,		'de',	'Ork'),			(6,		'en',	'Orc'),
(7,		'de',	'Troll'),		(7,		'en',	'Troll'),
(8,		'de',	'Taure'),		(8,		'en',	'Tauren')

GO

-- ClassRaceSettings

INSERT INTO [LootListManager].[dbo].[ClassRaceSettings] ( [FK_ClassId], [FK_RaceId] ) VALUES
(1,2),(1,3),(1,4),(1,5),(1,7),
(2,1),(2,3),(2,5),(2,7),
(3,1),(3,3),(3,5),(3,6),
(4,1),(4,2),(4,3),(4,4),(4,5),(4,6),(4,7),
(5,4),(5,8),
(6,2),(6,4),(6,6),(6,7),(6,8),
(7,6),(7,7),(7,8),
(8,1),(8,2),(8,3),(8,4),(8,5),(8,6),(8,7),(8,8),
(9,2),(9,3)

-- Items

-- ItemNames

-- ItemBossSettings