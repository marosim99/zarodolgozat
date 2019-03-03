-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Már 03. 23:55
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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `fotokeszites`
--

CREATE TABLE `fotokeszites` (
  `kepid` int(11) NOT NULL,
  `gepid` int(11) NOT NULL,
  `objektivid` int(11) NOT NULL,
  `userid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
  `objektiv` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
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
(5, 'Hasselblad', 'X1D-50c', 'MILC', 50, 'CMOS', 'XCD', 2247090),
(10, 'Leica', 'M-P', 'MILC', 24, 'CMOS', 'Leica M', 2180000),
(11, 'Leica', 'M10', 'MILC', 24, 'CMOS', 'Leica M', 2150000),
(12, 'Leica', 'M 240', 'MILC', 24, 'CMOS', 'Leica M, L', 2050000),
(13, 'Canon EOS', '1DX Mark II', 'DSLR', 20.2, 'CMOS', 'EF', 2049890),
(14, 'Fujifilm', 'GFX 50S', 'MILC', 51.4, 'CMOS', 'Fujifilm G', 1948890),
(15, 'Leica', 'SL', 'MILC', 24, 'CMOS', 'Leica L', 1829000),
(16, 'Pentax', '645Z', 'DSLR', 50, 'CMOS', '645AF2', 1799000);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kepek`
--

CREATE TABLE `kepek` (
  `id` int(11) NOT NULL,
  `fajlnev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `cim` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` varchar(150) COLLATE utf8_hungarian_ci NOT NULL,
  `hely` varchar(60) COLLATE utf8_hungarian_ci NOT NULL,
  `datum` date NOT NULL,
  `likes` int(11) NOT NULL,
  `neutral` int(11) NOT NULL,
  `dislike` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kepek`
--

INSERT INTO `kepek` (`id`, `fajlnev`, `cim`, `leiras`, `hely`, `datum`, `likes`, `neutral`, `dislike`) VALUES
(1, '1.jpg', 'Autó', 'Audi modellautó', 'Szeged', '2019-02-25', 2, 1, 0);

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
  `suly` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `objektiv`
--

INSERT INTO `objektiv` (`id`, `tipus`, `gyarto`, `nev`, `gyujtotav`, `stabil`, `minblende`, `maxblende`, `hossz`, `suly`) VALUES
(1, 'Leica M', 'Leica', 'Leica Noctilux-M', 50, 0, 16, 0.95, 75, 700),
(2, 'Leica L', 'Leica', 'Valami', 60, 1, 18, 0.8, 80, 800);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `profilepic`
--

CREATE TABLE `profilepic` (
  `id` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
  `bemutatkozas` varchar(500) COLLATE utf8_hungarian_ci NOT NULL,
  `regdatum` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `neme`, `email`, `bemutatkozas`, `regdatum`) VALUES
(27, 'admin', 'admin', 'férfi', 'admin@admin.com', 'Admin vagyok!', '2019-02-27'),
(28, 'proba1', 'Proba1@', 'férfi', 'proba1@proba.com', 'Próba1 profil.', '2019-03-03');

--
-- Indexek a kiírt táblákhoz
--

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
-- A tábla indexei `profilepic`
--
ALTER TABLE `profilepic`
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
-- AUTO_INCREMENT a táblához `gepek`
--
ALTER TABLE `gepek`
  MODIFY `id` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT a táblához `kepek`
--
ALTER TABLE `kepek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT a táblához `objektiv`
--
ALTER TABLE `objektiv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `profilepic`
--
ALTER TABLE `profilepic`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
