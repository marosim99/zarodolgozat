-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Már 24. 22:12
-- Kiszolgáló verziója: 10.1.37-MariaDB
-- PHP verzió: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `fotosseged`
--
CREATE DATABASE IF NOT EXISTS `fotosseged` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `fotosseged`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `chat`
--

CREATE TABLE `chat` (
  `uzenet_id` int(11) NOT NULL,
  `uzenet` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `datum` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `chat`
--

INSERT INTO `chat` (`uzenet_id`, `uzenet`, `datum`, `user_id`) VALUES
(14, 'Sziasztok, új vagyok még itt, tudnátok segíteni abban hogy hogyan tudok képet feltölteni ide? :D', '2019-03-24 20:33:04', 45),
(15, 'Szia szomszed88! A fényképek lenyíló menü utolsó pontjára kattintva eljutsz egy oldalra ahol tallózol egy képet és kitöltöd a mezőket, majd egyszerűen csak rányomsz a feltöltésre :D Sok sikert :)', '2019-03-24 20:35:00', 27),
(16, 'Sikerült is, kép képet is feltöltöttem :D köszi a segítséget', '2019-03-24 20:38:12', 45);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `fotokeszites`
--

CREATE TABLE `fotokeszites` (
  `kepid` int(11) NOT NULL,
  `gepid` int(11) NOT NULL,
  `userid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `fotokeszites`
--

INSERT INTO `fotokeszites` (`kepid`, `gepid`, `userid`) VALUES
(1, 1, 28),
(4, 3, 27),
(5, 4, 27),
(6, 14, 27),
(7, 17, 27),
(8, 13, 27),
(9, 16, 27),
(10, 19, 45),
(11, 25, 45);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gepek`
--

CREATE TABLE `gepek` (
  `id` smallint(6) NOT NULL,
  `gyarto` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `sorozat` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `tipus` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `pixel` double NOT NULL,
  `szenzor` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `objektiv` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `ar` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `gepek`
--

INSERT INTO `gepek` (`id`, `gyarto`, `sorozat`, `tipus`, `pixel`, `szenzor`, `objektiv`, `ar`) VALUES
(1, 'Leica', 'S', 'DSLR', 37.5, 'CCD', 'Leica S', 5860000),
(2, 'Leica', 'M10-P', 'DSLR', 24, 'CMOS', 'Leica M', 2640000),
(3, 'Leica', 'M Monochrom', 'DSLR', 18, 'CMOS', 'Leica M', 2346000),
(4, 'Nikon', 'D5', 'DSLR', 21.33, 'CMOS', 'Nikon F', 2299900),
(10, 'Leica', 'M-P', 'MILC', 24, 'CMOS', 'Leica M', 2180000),
(11, 'Leica', 'M10', 'MILC', 24, 'CMOS', 'Leica M', 2150000),
(12, 'Leica', 'M 240', 'MILC', 24, 'CMOS', 'Leica M', 2050000),
(13, 'Canon', 'EOS 1DX Mark II', 'DSLR', 20.2, 'CMOS', 'EF', 2049890),
(14, 'Fujifilm', 'GFX 50S', 'MILC', 51.4, 'CMOS', 'Fujifilm G', 1948890),
(15, 'Leica', 'SL', 'MILC', 24, 'CMOS', 'Leica L', 1829000),
(16, 'Pentax', '645Z', 'DSLR', 50, 'CMOS', '645AF2', 1799000),
(17, 'Panasonic', 'Lumix DC-FZ80', 'Bridge', 18, 'CMOS', '', 95000),
(18, 'Nikon', 'Coolpix P900', 'Bridge', 16, 'CMOS', '', 163790),
(19, 'Sony', 'Alpha 7 III', 'MILC', 25.3, 'CMOS', 'Sony E', 704900),
(20, 'Canon', 'EOS 4000D', 'DSLR', 18.7, 'CMOS', 'EF', 107900),
(21, 'Nikon', 'Coolpix P1000', 'Bridge', 16.79, 'CMOS', '', 319700),
(22, 'Nikon', 'Coolpix B500', 'Bridge', 16.76, 'CMOS', '', 79585),
(23, 'Sony', 'Alpha 6000', 'MILC', 24.3, 'CMOS', 'Sony E', 179790),
(24, 'Nikon', 'D3500', 'DSLR', 24.78, 'CMOS', 'Nikon F', 133990),
(25, 'Canon', 'EOS 750D', 'DSLR', 24.2, 'CMOS', 'EF', 154990),
(26, 'Canon', 'EOS M50', 'MILC', 24.1, 'CMOS', 'EF-M', 223990),
(27, 'Fujifilm', 'X-T20', 'MILC', 24.3, 'CMOS', 'FUJIFILM X', 344890),
(28, 'Fujifilm', 'X-T3', 'MILC', 26.1, 'CMOS', 'Fujifilm X', 599990),
(31, 'Panasonic', 'DMC-G80', 'MILC', 16.84, 'MOS', 'Micro 4/3', 219890),
(32, 'Panasonic', 'Lumix DC-GH5', 'MILC', 20.3, 'MOS', 'Micro 4/3', 529990),
(33, 'Panasonic', 'Lumix DMC-FZ1000', 'Bridge', 20.1, 'MOS', '', 196790),
(34, 'Pentax', 'K-1 Mark II', 'DSLR', 36.4, 'CMOS', 'PENTAX KAF', 644900),
(35, 'Pentax', 'K-S2', 'DSLR', 20.1, 'CMOS', 'PENTAX KAF', 244990),
(36, 'Sony', 'DSC-H300', 'Bridge', 20.1, 'CCD', '', 59890),
(37, 'Sony', 'Alpha 5100L', 'MILC', 24.3, 'CMOS', 'Sony E', 165890);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kepek`
--

CREATE TABLE `kepek` (
  `id` int(11) NOT NULL,
  `fajlnev` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `cim` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(150) COLLATE utf8_hungarian_ci NOT NULL,
  `hely` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `feltolt_datum` date NOT NULL,
  `keszites_datum` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kepek`
--

INSERT INTO `kepek` (`id`, `fajlnev`, `cim`, `leiras`, `hely`, `feltolt_datum`, `keszites_datum`) VALUES
(1, '1.jpg', 'Autó', 'Audi modellautó', 'Szeged', '2019-02-25', '2019-03-17'),
(4, 'P1040277.jpg', 'Naplemente a panel mögött', 'Szép, kontrasztos kép egy egyébként unalmas naplementéről', 'Szeged', '2019-03-23', '2019-03-12'),
(5, 'P1030623.jpg', 'Egy darabka hold', 'Nikon D5-el fotóztam :)', 'Budapest', '2019-03-23', '2019-03-01'),
(6, 'P1040287.jpg', 'Feltörő napsugarak', 'Ég az égbolt :)))', 'Kecskemét', '2019-03-23', '2019-03-08'),
(7, 'R4.jpg', 'SF71H', 'Kedvenc modellautóm közelről', 'Kiskunfélegyháza', '2019-03-23', '2019-03-01'),
(8, 'P1000731.jpg', 'Padlólemezcsere', 'A srácok padlólemezt cserélnek a Renault-on, miután olajszivárgást észleltek a váltóház körül', 'Mogyoród', '2019-03-23', '2018-08-01'),
(9, 'P1010611.jpg', 'Napsugarak a balaton felett', 'Imádjuk a balatont, főleg amikor ilyen naplementéket láthatunk', 'Balatonföldvár', '2019-03-23', '2018-08-04'),
(10, 'P1030157.jpg', 'Formáció repülés', 'Kedvenc képem a kedvenc gépemmel (mármint fényképezőgéppel) :)))', 'Szeged', '2019-03-24', '2018-09-22'),
(11, 'P1010278.jpg', 'Kacsa :P', 'És még pózolt is a képhez, hát nem aranyos? :D', 'Siófok', '2019-03-24', '2018-08-02');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `objektiv`
--

CREATE TABLE `objektiv` (
  `id` int(11) NOT NULL,
  `tipus` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `gyarto` varchar(15) COLLATE utf8_hungarian_ci NOT NULL,
  `nev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `gyujtotav` int(11) NOT NULL,
  `stabil` tinyint(1) NOT NULL,
  `minblende` float NOT NULL,
  `maxblende` float NOT NULL,
  `hossz` int(11) NOT NULL,
  `suly` int(11) NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `objektiv`
--

INSERT INTO `objektiv` (`id`, `tipus`, `gyarto`, `nev`, `gyujtotav`, `stabil`, `minblende`, `maxblende`, `hossz`, `suly`, `ar`) VALUES
(2, 'Leica L', 'Leica', 'Leica Noctilux-L', 60, 1, 18, 0.8, 80, 800, 3610000),
(7, 'Leica M', 'Leica', 'Noctilux-M', 50, 0, 16, 0.95, 75, 700, 3590000),
(8, 'Leica M', 'ZEISS', 'Tele-Tessar T', 85, 0, 22, 4, 95, 310, 269900),
(9, 'Nikon F', 'Nikon', 'AF-S', 50, 0, 16, 1.8, 53, 185, 64900),
(10, 'Nikon F', 'Samyang', 'IF ED UMC Asp', 14, 0, 22, 2.8, 86, 560, 129890),
(11, 'Nikon F', 'SIGMA', 'EX DC OS HSM', 17, 1, 22, 2.8, 92, 565, 134890),
(12, 'Fujifilm G', 'Fujifilm', 'OIS WR Macro', 120, 1, 32, 4, 152, 980, 998890),
(13, 'Fujifilm G', 'Fujifilm', 'R LM WR', 110, 0, 22, 2, 125, 1010, 1044890),
(14, 'Sony E', 'Sony', 'SEL-P18105G', 18, 1, 22, 4, 110, 427, 189900),
(15, 'Sony E', 'Sony', 'SEL-50F18 E', 50, 1, 22, 1.8, 62, 202, 83900),
(16, 'Micro 4/3', 'Samyang', 'NCS CS Cine', 12, 0, 22, 2.2, 28, 255, 119890),
(17, 'Micro 4/3', 'Samyang', 'AS UMC Tilt-Shift', 24, 0, 22, 3.5, 113, 200, 309900);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_hungarian_ci NOT NULL,
  `neme` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `bemutatkozas` text COLLATE utf8_hungarian_ci NOT NULL,
  `regdatum` date NOT NULL,
  `admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `neme`, `email`, `bemutatkozas`, `regdatum`, `admin`) VALUES
(1, 'marosim99', '$2y$10$zm4NiP0wdHpqJtMvI/SEgeSXAiRsvnYJ.0c6yneDpr2JBnBmzKayi', 'férfia', 'marosim99@gmail.com', 'dxsct fgvzhnjkm,l>$d fcvzghnjkom,l>$*sd', '2019-03-17', 1),
(27, 'admin', '$2y$10$zm4NiP0wdHpqJtMvI/SEgeSXAiRsvnYJ.0c6yneDpr2JBnBmzKayi', 'férfi', 'admin@admin.com', 'Admin vagyok!', '2019-02-27', 1),
(28, 'proba1', '$2y$10$zm4NiP0wdHpqJtMvI/SEgeSXAiRsvnYJ.0c6yneDpr2JBnBmzKayi', 'férfi', 'proba1@proba.com', 'Próba1 profil.', '2019-03-03', 0),
(39, 'KimiRaikkonen7', '$2y$10$zm4NiP0wdHpqJtMvI/SEgeSXAiRsvnYJ.0c6yneDpr2JBnBmzKayi', 'nő', 'kimi7@alfaromeo.com', 'Kimi vagyok. Bwoah.', '2019-03-17', 0),
(45, 'szomszed88', '$2y$10$zm4NiP0wdHpqJtMvI/SEgeSXAiRsvnYJ.0c6yneDpr2JBnBmzKayi', 'férfi', 'szomszed@gmail.com', 'Még elég új vagyok fotózás terén :D', '2019-03-24', 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `chat`
--
ALTER TABLE `chat`
  ADD PRIMARY KEY (`uzenet_id`),
  ADD KEY `user_id_2` (`user_id`);

--
-- A tábla indexei `fotokeszites`
--
ALTER TABLE `fotokeszites`
  ADD PRIMARY KEY (`kepid`);

--
-- A tábla indexei `gepek`
--
ALTER TABLE `gepek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kepek`
--
ALTER TABLE `kepek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `objektiv`
--
ALTER TABLE `objektiv`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `chat`
--
ALTER TABLE `chat`
  MODIFY `uzenet_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT a táblához `fotokeszites`
--
ALTER TABLE `fotokeszites`
  MODIFY `kepid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `gepek`
--
ALTER TABLE `gepek`
  MODIFY `id` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT a táblához `kepek`
--
ALTER TABLE `kepek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT a táblához `objektiv`
--
ALTER TABLE `objektiv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
