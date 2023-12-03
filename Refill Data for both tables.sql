-- Insert data into CharacterTable
INSERT INTO CharacterTable (
    character_ID, [password], name, level, gender, race, role, strength, dexterity, constitution, intelligence, wisdom, charisma
) VALUES
    (1, 'sP@ssw0rd!XyZ', 'QuantumGlider', 10, 'Female', 'Elf', 'Rogue', 6, 4, 3, 5, 2, 8),
    (2, '7H&fj9@L*2sP', 'PixelPioneer', 5, 'Non-binary', 'Dwarf', 'Paladin', 3, 5, 4, 6, 2, 8),
    (3, 'Qwerty12$abcd', 'MysticWhisper', 12, 'Male', 'Half-Orc', 'Cleric', 2, 7, 3, 5, 4, 7),
    (4, '*P@55w0rd!Zz', 'TechVoyager', 3, 'Trans', 'Halfling', 'Bard', 4, 6, 3, 5, 2, 8),
    (5, 'R4nd0mP@$$wrd', 'StarlightJourney', 8, 'Non-binary', 'Dragonborn', 'Barbarian', 5, 4, 6, 3, 1, 9),
    (6, '9Gh#jkl$3mNo', 'CipherSpark', 16, 'Male', 'Human', 'Fighter', 3, 6, 2, 5, 4, 8),
    (7, 'P@$$c0d3!XY', 'NeonNebula', 7, 'Female', 'Tiefling', 'Sorcerer', 6, 3, 4, 7, 1, 7),
    (8, '5tR0nGp@55W', 'SereneCipher', 4, 'Trans', 'Gnome', 'Druid', 2, 5, 4, 6, 3, 8),
    (9, 'bCd3$fGh!78', 'LunaRanger', 11, 'Non-binary', 'Elf', 'Monk', 4, 3, 6, 5, 1, 9),
    (10, 'Pa$$w0rd$123', 'SonicNova', 9, 'Male', 'Half-Elf', 'Warlock', 3, 6, 4, 5, 2, 8),
    (11, '*L0nG&c0mP1', 'CyberEcho', 13, 'Female', 'Halfling', 'Wizard', 7, 2, 6, 4, 1, 8),
    (12, 'qwerty&$567', 'GalaxySeeker', 2, 'Trans', 'Dwarf', 'Bard', 4, 5, 3, 6, 1, 9),
    (13, '12Pa$$W0rd#@', 'ByteBlaze', 18, 'Non-binary', 'Human', 'Fighter', 6, 4, 5, 2, 3, 8),
    (14, 'Examp1e$Pass', 'PhoenixRider', 6, 'Male', 'Tiefling', 'Cleric', 3, 5, 2, 6, 4, 8),
    (15, 'P@ssw0rd123!', 'ZenithKnight', 15, 'Female', 'Half-Orc', 'Rogue', 5, 3, 4, 7, 2, 7),
    (16, '$ecUr3P@$$W', 'CosmicOracle', 1, 'Trans', 'Gnome', 'Barbarian', 2, 6, 3, 4, 5, 8),
    (17, '8T&H9$zL0pQ', 'TerraByte', 17, 'Non-binary', 'Dragonborn', 'Paladin', 4, 7, 2, 5, 3, 7),
    (18, 'T3stP@$$w0rd', 'CelestialPulse', 14, 'Male', 'Human', 'Monk', 6, 2, 5, 3, 4, 8),
    (19, '4R@nd0M!p@$$', 'AuroraGaze', 19, 'Female', 'Elf', 'Wizard', 3, 4, 5, 6, 2, 8),
    (20, 'p@ssWORD&567', 'DataPioneer', 20, 'Trans', 'Half-Elf', 'Sorcerer', 5, 6, 3, 4, 2, 8),
    (21, 'L0ngP@$$w0rd', 'SolarSpecter', 10, 'Non-binary', 'Tiefling', 'Rogue', 4, 5, 2, 6, 3, 8),
    (22, '67@BcdeFgH$!', 'EmberQuest', 5, 'Male', 'Halfling', 'Warlock', 6, 4, 3, 5, 2, 8),
    (23, 'D3m0P@$$w0rd', 'NovaFusion', 12, 'Female', 'Dwarf', 'Druid', 2, 7, 4, 3, 6, 6),
    (24, 'Pa$$w0rd_999', 'QuantumQuester', 3, 'Trans', 'Dragonborn', 'Bard', 5, 3, 6, 4, 2, 8),
    (25, 'Qw3rty&987!', 'PixelPulse', 8, 'Non-binary', 'Half-Orc', 'Cleric', 3, 4, 2, 7, 5, 7),
    (26, '$Tr0ngp@$$12', 'CyberVortex', 16, 'Male', 'Gnome', 'Fighter', 7, 2, 5, 4, 3, 7),
    (27, '6H&jKL@9$3sP', 'GalacticWhisper', 7, 'Female', 'Human', 'Paladin', 4, 6, 3, 2, 5, 8),
    (28, 'R@nD0mP@$$#1', 'SereneSpectrum', 4, 'Trans', 'Tiefling', 'Barbarian', 6, 5, 4, 2, 3, 8),
    (29, 'P@55W0rd&321', 'PhotonPioneer', 11, 'Non-binary', 'Elf', 'Monk', 3, 6, 4, 2, 5, 8),
    (30, '*Myp@$$w0rd!', 'MystiqueBlaze', 9, 'Male', 'Half-Elf', 'Sorcerer', 5, 4, 3, 6, 1, 9);

    -- Insert data into SessionTable for each character
INSERT INTO SessionTable (
    session_ID, name, notes, character_ID
)
SELECT
    character_ID, 
    'Session ' + CAST(character_ID AS NVARCHAR(10)) AS name,
    'Notes for Session ' + CAST(character_ID AS NVARCHAR(10)) AS notes,
    character_ID
FROM
    CharacterTable;
