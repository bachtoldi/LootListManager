-- Users

INSERT INTO [LootListManager].[dbo].[Users] ( [UserName], [PasswordHash], [UserLoginAttempts] ) VALUES
('armon', 'asdf', 0),
('test', 'asdf', 0)

-- Instances

SET IDENTITY_INSERT [LootListManager].[dbo].[Instances] ON

INSERT INTO [LootListManager].[dbo].[Instances] ( [InstanceId], [InstanceLogicalId], [InstanceSort] ) VALUES
(1, 'ony', 1), 
(2, 'mc', 2), 
(3, 'zg', 3), 
(4, 'bwl', 4), 
(5, 'aq20', 5), 
(6, 'aq40', 6), 
(7, 'nax', 7), 
(8, 'wb', 8)

SET IDENTITY_INSERT [LootListManager].[dbo].[Instances] OFF

GO

-- InstanceNames
INSERT INTO [LootListManager].[dbo].[InstanceNames] ( [LogicalId], [Culture], [Value] ) VALUES
('ony',		'de',	'Onyxias Hort'),			('ony',		'en',	'Onyxia''s Lair'),
('mc',		'de',	'Geschmolzener Kern'),		('mc',		'en',	'Molten Core'),
('zg',		'de',	'Zul''Gurub'),				('zg',		'en',	'Zul''Gurub'),
('bwl',		'de',	'Pechschwingenhort'),		('bwl',		'en',	'Blackwinglair'),
('aq20',	'de',	'Ruinen von Ahn''Qiraj'),	('aq20',	'en',	'Ruins of Ahn''Qiraj'),
('aq40',	'de',	'Tempel von Ahn''Qiraj'),	('aq40',	'en',	'Temple of Ahn''Qiraj'),
('nax',		'de',	'Naxxramas'),				('nax',		'en',	'Naxxramas'),
('wb',		'de',	'Weltbosse'),				('wb',		'en',	'World Bosses')

GO

-- Bosses

SET IDENTITY_INSERT [LootListManager].[dbo].[Bosses] ON

INSERT INTO [LootListManager].[dbo].[Bosses] ( [BossId], [BossLogicalId], [BossSort], [FK_InstanceId] ) VALUES
(1,		'onyxia',		1,		1),

(2,		'luci',			1,		2),
(3,		'magma',		2,		2),
(4,		'gehe',			3,		2),
(5,		'garr',			4,		2),
(6,		'shazz',		5,		2),
(7,		'geddon',		6,		2),
(8,		'sulfuron',		7,		2),
(9,		'gole',			8,		2),
(10,	'majo',			9,		2),
(11,	'raggi',		10,		2),
(12,	'mctrash',		11,		2),

(13,	'jeklik',		1,		3),
(14,	'venoxis',		2,		3),
(15,	'marli',		3,		3),
(16,	'thekal',		4,		3),
(17,	'arlokk',		5,		3),
(18,	'mando',		6,		3),
(19,	'jindo',		7,		3),
(20,	'gahz',			8,		3),
(21,	'madness',		9,		3),
(22,	'hakkar',		10,		3),
(23,	'zgtrash',		11,		3),

(24,	'razo',			1,		4),
(25,	'vael',			2,		4),
(26,	'lash',	3,		4),
(27,	'flamegor',		4,		4),
(28,	'ebonroc',		5,		4),
(29,	'firemaw',		6,		4),
(30,	'chrommi',		7,		4),
(31,	'nef',			8,		4),
(32,	'bwltrash',		9,		4),

(33,	'kurinaxx',		1,		5),
(34,	'rajaxx',		2,		5),
(35,	'moam',			3,		5),
(36,	'buru',			4,		5),
(37,	'aya',			5,		5),
(38,	'ossi',			6,		5),
(39,	'aq20trash',	7,		5),

(40,	'skeram',		1,		6),
(41,	'bugs',			2,		6),
(42,	'sartura',		3,		6),
(43,	'fankriss',		4,		6),
(44,	'visci',		5,		6),
(45,	'huhu',			6,		6),
(46,	'twins',		7,		6),
(47,	'ouro',			8,		6),
(48,	'cthun',		9,		6),
(49,	'aq40trash',	10,		6),

(50,	'anub',			1,		7),
(51,	'widow',		2,		7),
(52,	'maexxna',		3,		7),
(53,	'noth',			4,		7),
(54,	'heigan',		5,		7),
(55,	'loatheb',		6,		7),
(56,	'razuvi',		7,		7),
(57,	'gothik',		8,		7),
(58,	'horsemen',		9,		7),
(59,	'patchwork',	10,		7),
(60,	'grobbulus',	11,		7),
(61,	'gluth',		12,		7),
(62,	'thaddius',		13,		7),
(63,	'saphiron',		14,		7),
(64,	'kel',			15,		7),
(65,	'naxtrash',		16,		7),

(66,	'kazzak',		1,		8),
(67,	'azu',			2,		8),
(68,	'ysondre',		3,		8),
(69,	'lethon',		4,		8),
(70,	'taerar',		5,		8),
(71,	'emeriss',		6,		8)

SET IDENTITY_INSERT [LootListManager].[dbo].[Bosses] OFF

GO

-- BossNames

INSERT INTO [LootListManager].[dbo].[BossNames] ( [LogicalId], [Culture], [Value] ) VALUES
('onyxia',		'de',	'Onyxia'),						('onyxia',		'en', 'Onyxia'),

('luci',		'de',	'Lucifron'),					('luci',		'en',	'Lucifron'),
('magma',		'de',	'Magmadar'),					('magma',		'en',	'Magmadar'),
('gehe',		'de',	'Gehennas'),					('gehe',		'en',	'Gehennas'),
('garr',		'de',	'Garr'),						('garr',		'en',	'Garr'),
('shazz',		'de',	'Shazzrah'),					('shazz',		'en',	'Shazzrah'),
('geddon',		'de',	'Baron Geddon'),				('geddon',		'en',	'Baron Geddon'),
('sulfuron',	'de',	'Sulfuronherold'),				('sulfuron',	'en',	'Sulfuron Herold'),
('gole',		'de',	'Golemagg der Verbrenner'),		('gole',		'en',	'Golemagg the Incinerator'),
('majo',		'de',	'Majordomus Exekutus'),			('majo',		'en',	'Majordomo Executus'),
('raggi',		'de',	'Ragnaros'),					('raggi',		'en',	'Ragnaros'),
('mctrash',		'de',	'Trash'),						('mctrash',		'en',	'Trash'),

('jeklik',		'de',	'Hohepriesterin Jeklik'),		('jeklik',		'en',	'High Priestess Jeklik'),
('venoxis',		'de',	'Hohepriester Venoxis'),		('venoxis',		'en',	'High Priest Venoxis'),
('marli',		'de',	'Hohepriesterin Mar''li'),		('marli',		'en',	'High Priestess Mar''li'),
('thekal',		'de',	'Hohepriester Thekal'),			('thekal',		'en',	'High Priest Thekal'),
('arlokk',		'de',	'Hohepriesterin Arlokk'),		('arlokk',		'en',	'High Priestess Arlokk'),
('mando',		'de',	'Blutfürst Mandokir'),			('mando',		'en',	'Bloodlord Mandokir'),
('jindo',		'de',	'Jin''do der Verhexer'),		('jindo',		'en',	'Jin''do the Hexxer'),
('gahz',		'de',	'Gahz''ranka'),					('gahz',		'en',	'Gahz''ranka'),
('madness',		'de',	'Hort des Wahnsinns'),			('madness',		'en',	'Edge of Madness'),
('hakkar',		'de',	'Hakkar'),						('hakkar',		'en',	'Hakkar'),
('zgtrash',		'de',	'Trash'),						('zgtrash',		'en',	'Trash'),

('razo',		'de',	'Feuerkralle der Ungezähmte'),	('razo',		'en',	'Razorgore the Untamed'),
('vael',		'de',	'Vaelastrasz'),					('vael',		'en',	'Vaelastrasz the Corrupt'),
('lash',		'de',	'Brutwächter Dreschbringer'),	('lash',		'en',	'Broodlord Lashlayer'),
('flamegor',	'de',	'Feuerschwinge'),				('flamegor',	'en',	'Flamegor'),
('ebonroc',		'de',	'Schattenschwinge'),			('ebonroc',		'en',	'Ebonroc'),
('firemaw',		'de',	'Flammenmaul'),					('firemaw',		'en',	'Firemaw'),
('chrommi',		'de',	'Chromagus'),					('chrommi',		'en',	'Chromaggus'),
('nef',			'de',	'Nefarian'),					('nef',			'en',	'Nefarian'),
('bwltrash',	'de',	'Trash'),						('bwltrash',	'en',	'Trash'),

('kurinaxx',	'de',	'Kurinaxx'),					('kurinaxx',	'en',	'Kurinaxx'),
('rajaxx',		'de',	'General Rajaxx'),				('rajaxx',		'en',	'General Rajaxx'),
('moam',		'de',	'Moam'),						('moam',		'en',	'Moam'),
('buru',		'de',	'Buru der Verschlinger'),		('buru',		'en',	'Buru the Gorger'),
('aya',			'de',	'Ayamiss der Jäger'),			('aya',			'en',	'Ayamiss the Hunter'),
('ossi',		'de',	'Ossirian der Narbenlose'),		('ossi',		'en',	'Ossirian the Unscarred'),
('aq20trash',	'de',	'Trash'),						('aq20trash',	'en',	'Trash'),

('skeram',		'de',	'Der Prophet Skeram'),			('skeram',		'en',	'The Prophet Skeram'),
('bugs',		'de',	'Adel der Silithiden'),			('bugs',		'en',	'Silithid Royalty'),
('sartura',		'de',	'Schlachtwache Sartura'),		('sartura',		'en',	'Battleguard Sartura'),
('fankriss',	'de',	'Fankriss der Unnachgiebige'),	('fankriss',	'en',	'Fankriss the Unyielding'),
('visci',		'de',	'Viscidus'),					('visci',		'en',	'Viscidus'),
('huhu',		'de',	'Prinzessin Huhuran'),			('huhu',		'en',	'Princess Huhuran'),
('twins',		'de',	'Zwilingsimperatoren'),			('twins',		'en',	'The Twin Emperors'),
('ouro',		'de',	'Ouro'),						('ouro',		'en',	'Ouro'),
('cthun',		'de',	'C''Thun'),						('cthun',		'en',	'C''Thun'),
('aq40trash',	'de',	'Trash'),						('aq40trash',	'en',	'Trash'),

('anub',		'de',	'Anub''Rekhan'),				('anub',		'en',	'Anub''Rekhan'),
('widow',		'de',	'Großwitwe Faerlina'),			('widow',		'en',	'Grand Widow Faerlina'),
('maexxna',		'de',	'Maexxna'),						('maexxna',		'en',	'Maexxna'),
('noth',		'de',	'Noth der Seuchenfürst'),		('noth',		'en',	'Noth the Plaguebringer'),
('heigan',		'de',	'Heigan der Unreine'),			('heigan',		'en',	'Heigan the Unclean'),
('loatheb',		'de',	'Loatheb'),						('loatheb',		'en',	'Loatheb'),
('razuvi',		'de',	'Instrukteur Razuvious'),		('razuvi',		'en',	'Instructor Razuvious'),
('gothik',		'de',	'Gothik der Seelenjäger'),		('gothik',		'en',	'Gothik the Harvester'),
('horsemen',	'de',	'Die vier Reiter'),				('horsemen',	'en',	'The Four Horsemen'),
('patchwork',	'de',	'Flickwerk'),					('patchwork',	'en',	'Patchwork'),
('grobbulus',	'de',	'Grobbulus'),					('grobbulus',	'en',	'Grobbulus'),
('gluth',		'de',	'Gluth'),						('gluth',		'en',	'Gluth'),
('thaddius',	'de',	'Thaddius'),					('thaddius',	'en',	'Thaddius'),
('saphiron',	'de',	'Saphiron'),					('saphiron',	'en',	'Sapphiron'),
('kel',			'de',	'Kel''Thuzad'),					('kel',			'en',	'Kel''Thuzad'),
('naxtrash',	'de',	'Trash'),						('naxtrash',	'en',	'Trash'),

('kazzak',		'de',	'Kazzak'),						('kazzak',		'en',	'Kazzak'),
('azu',			'de',	'Azuregos'),					('azu',			'en',	'Azuregos'),
('ysondre',		'de',	'Ysondre'),						('ysondre',		'en',	'Ysondre'),
('lethon',		'de',	'Lethon'),						('lethon',		'en',	'Lethon'),
('taerar',		'de',	'Taerar'),						('taerar',		'en',	'Taerar'),
('emeriss',		'de',	'Emeriss'),						('emeriss',		'en',	'Emeriss')

GO

-- Classes

SET IDENTITY_INSERT [LootListManager].[dbo].[Classes] ON

INSERT INTO [LootListManager].[dbo].[Classes] ( [ClassId], [ClassLogicalId] ) VALUES
(1, 'priest'),
(2,	'mage'),
(3,	'wl'),
(4,	'rogue'),
(5,	'druid'),
(6,	'hunter'),
(7,	'shami'),
(8,	'warri'),
(9,	'pala')

SET IDENTITY_INSERT [LootListManager].[dbo].[Classes] OFF

GO

-- ClassNames

INSERT INTO [LootListManager].[dbo].[ClassNames] ( [LogicalId], [Culture], [Value] ) VALUES
('priest',	'de',	'Priester'),		('priest',	'en',	'Priest'),
('mage',	'de',	'Magier'),			('mage',	'en',	'Mage'),
('wl',		'de',	'Hexenmeister'),	('wl',		'en',	'Warlock'),
('rogue',	'de',	'Schurke'),			('rogue',	'en',	'Rogue'),
('druid',	'de',	'Druide'),			('druid',	'en',	'Druid'),
('hunter',	'de',	'Jäger'),			('hunter',	'en',	'Hunter'),
('shami',	'de',	'Schamane'),		('shami',	'en',	'Shaman'),
('warri',	'de',	'Krieger'),			('warri',	'en',	'Warrior'),
('pala',	'de',	'Paladin'),			('pala',	'en',	'Paladin')

GO

-- Talents

SET IDENTITY_INSERT [LootListManager].[dbo].[Talents] ON

INSERT INTO [LootListManager].[dbo].[Talents] ( [TalentId], [TalentLogicalId], [FK_ClassId] ) VALUES
(1,		'holypr',	1),
(2,		'disc',		1),
(3,		'shadow',	1),

(4,		'frost',	2),
(5,		'fire',		2),
(6,		'arcane',	2),

(7,		'affli',	3),
(8,		'destro',	3),
(9,		'demo',		3),

(10,	'combat',	4),
(11,	'sub',		4),
(12,	'ass',		4),

(13,	'feral',	5),
(14,	'balance',	5),
(15,	'restod',	5),

(16,	'surv',		6),
(17,	'mark',		6),
(18,	'beast',	6),

(19,	'restos',	7),
(20,	'enh',		7),
(21,	'ele',		7),

(22,	'protw',	8),
(23,	'arms',		8),
(24,	'fury',		8),

(25,	'holypa',	9),
(26,	'protp',	9),
(27,	'ret',		9)

SET IDENTITY_INSERT [LootListManager].[dbo].[Talents] OFF

GO

-- TalentNames

INSERT INTO [LootListManager].[dbo].[TalentNames] ( [LogicalId], [Culture], [Value] ) VALUES
('holypr',	'de',	'Heilig'),				('holypr',	'en',	'Holy'),
('disc',	'de',	'Disziplin'),			('disc',	'en',	'Discipline'),
('shadow',	'de',	'Schatten'),			('shadow',	'en',	'Shadow'),

('frost',	'de',	'Frost'),				('frost',	'en',	'Frost'),
('fire',	'de',	'Feuer'),				('fire',	'en',	'Fire'),
('arcane',	'de',	'Arkan'),				('arcane',	'en',	'Arcane'),

('affli',	'de',	'Gebrechen'),			('affli',	'en',	'Affliction'),
('destro',	'de',	'Zerstörung'),			('destro',	'en',	'Descruction'),
('demo',	'de',	'Dämonologie'),			('demo',	'en',	'Demonology'),

('combat',	'de',	'Kampf'),				('combat',	'en',	'Combat'),
('sub',		'de',	'Täuschung'),			('sub',		'en',	'Subtlety'),
('ass',		'de',	'Meucheln'),			('ass',		'en',	'Assassination'),

('feral',	'de',	'Wilder Kampf'),		('feral',	'en',	'Feral'),
('balance',	'de',	'Gleichgewicht'),		('balance',	'en',	'Balance'),
('restod',	'de',	'Wiederherstellung'),	('restod',	'en',	'Restoration'),

('surv',	'de',	'Überleben'),			('surv',	'en',	'Survival'),
('mark',	'de',	'Treffsicherheit'),		('mark',	'en',	'Marksmanship'),
('beast',	'de',	'Tierherrschaft'),		('beast',	'en',	'Beast Mastery'),

('restos',	'de',	'Wiederherstellung'),	('restos',	'en',	'Restoration'),
('enh',		'de',	'Verstärkung'),			('enh',		'en',	'Enhancement'),
('ele',		'de',	'Elementar'),			('ele',		'en',	'Elemental'),

('protw',	'de',	'Schutz'),				('protw',	'en',	'Protection'),
('arms',	'de',	'Waffen'),				('arms',	'en',	'Arms'),
('fury',	'de',	'Furor'),				('fury',	'en',	'Fury'),

('holypa',	'de',	'Heilig'),				('holypa',	'en',	'Holy'),
('protp',	'de',	'Schutz'),				('protp',	'en',	'Protection'),
('ret',		'de',	'Vergeltung'),			('ret',		'en',	'Retribution')

GO

-- Factions

SET IDENTITY_INSERT [LootListManager].[dbo].[Factions] ON

INSERT INTO [LootListManager].[dbo].[Factions] ( [FactionId], [FactionLogicalId] ) VALUES
(1, 'ally'),
(2, 'horde')

SET IDENTITY_INSERT [LootListManager].[dbo].[Factions] OFF

GO

-- FactionNames

INSERT INTO [LootListManager].[dbo].[FactionNames] ( [LogicalId], [Culture], [Value] ) VALUES
('ally',	'de',	'Allianz'),		('ally',	'en',	'Alliance'),
('horde',	'de',	'Horde'),		('horde',	'en',	'Horde')

GO

-- Races

SET IDENTITY_INSERT [LootListManager].[dbo].[Races] ON

INSERT INTO [LootListManager].[dbo].[Races] ( [RaceId], [RaceLogicalId], [FK_FactionId] ) VALUES
(1,		'gnome'		,1),
(2,		'dwarf'		,1),
(3,		'human'		,1),
(4,		'ne'		,1),
(5,		'ud'		,2),
(6,		'orc'		,2),
(7,		'troll'		,2),
(8,		'tauren'	,2)

SET IDENTITY_INSERT [LootListManager].[dbo].[Races] OFF

GO

-- RaceNames

INSERT INTO [LootListManager].[dbo].[RaceNames] ( [LogicalId], [Culture], [Value] ) VALUES
('gnome',	'de',	'Gnom'),		('gnome',	'en',	'Gnome'),
('dwarf',	'de',	'Zwerg'),		('dwarf',	'en',	'Dwarf'),
('human',	'de',	'Mensch'),		('human',	'en',	'Human'),
('ne',		'de',	'Nachtelf'),	('ne',		'en',	'Nightelf'),
('ud',		'de',	'Untot'),		('ud',		'en',	'Undead'),
('orc',		'de',	'Ork'),			('orc',		'en',	'Orc'),
('troll',	'de',	'Troll'),		('troll',	'en',	'Troll'),
('tauren',	'de',	'Taure'),		('tauren',	'en',	'Tauren')

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

-- Roles
INSERT INTO [LootListManager].[dbo].[Roles] ( [RoleName] ) VALUES
( 'User' ),
( 'Admin' )