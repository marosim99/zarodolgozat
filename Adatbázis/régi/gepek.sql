-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2018 at 10:43 PM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fotosseged`
--

-- --------------------------------------------------------

--
-- Table structure for table `gepek`
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
-- Dumping data for table `gepek`
--

INSERT INTO `gepek` (`id`, `gyarto`, `sorozat`, `tipus`, `pixel`, `szenzor`, `objektiv`, `ar`) VALUES
(1, 'Leica', 'S', 'DSLR', 37.5, 'CCD', 'Leica S', 5860000),
(2, 'Leica', 'M10-P', 'Full frame', 24, 'CMOS', 'Leica M', 2640000),
(3, 'Leica', 'M Monochrom', 'DSLR', 18, 'CMOS', 'Leica M', 2346000),
(4, 'Nikon', 'D5', 'DSLR', 21.33, 'CMOS', 'Nikon F', 2299900),
(5, 'Hasselblad', 'X1D-50c', 'MILC', 50, 'CMOS', 'XCD', 2247090),
(10, 'Leica', 'M-P', 'MILC', 24, 'CMOS', 'Leica M', 2180000),
(11, 'Leica', 'M10', 'MILC', 24, 'CMOS', 'Leica M', 2150000),
(12, 'Leica', 'M 240', 'MILC', 24, 'CMOS', 'Leica M, L', 2050000),
(13, 'Canon EOS', '1DX Mark II', 'DSLR', 20.2, 'CMOS', 'EF', 2049890),
(14, 'Fujifilm', 'GFX 50S', 'MILC', 51.4, 'CMOS', 'Fujifilm G', 1948890),
(15, 'Leica', 'SL', 'MILC', 24, 'CMOS', 'Leica L', 1829000),
(16, 'Pentax', '645Z', 'DSLR', 51, 'CMOS', '645AF2', 1799000),
(18, 'asd', 'asd', 'asd', 22, 'asd', 'ad', 2),
(19, 'asd', 'asd', 'sad', 33, 'asda', 'asd', 3333);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gepek`
--
ALTER TABLE `gepek`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `gepek`
--
ALTER TABLE `gepek`
  MODIFY `id` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
