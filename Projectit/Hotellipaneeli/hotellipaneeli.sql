-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 04, 2024 at 06:19 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotellipaneeli`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `AsiakasID` int(11) NOT NULL,
  `Etunimi` varchar(50) DEFAULT NULL,
  `Sukunimi` varchar(50) DEFAULT NULL,
  `Lähiosoite` varchar(100) DEFAULT NULL,
  `Postinumero` varchar(10) DEFAULT NULL,
  `Postitoimipaikka` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`AsiakasID`, `Etunimi`, `Sukunimi`, `Lähiosoite`, `Postinumero`, `Postitoimipaikka`) VALUES
(1, 'Jan Erik', 'Lee', 'Keskikatu 3', '04200', 'Kerava'),
(2, 'Jyri', 'Lindroos', 'Keskikatu 3', '04200', 'Kerava');

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

CREATE TABLE `huoneet` (
  `HuoneenNro` int(11) NOT NULL,
  `Huonetyyppi` varchar(50) DEFAULT NULL,
  `Puhelin` varchar(20) DEFAULT NULL,
  `Vapaana` enum('Kyllä','Ei') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `huoneet`
--

INSERT INTO `huoneet` (`HuoneenNro`, `Huonetyyppi`, `Puhelin`, `Vapaana`) VALUES
(123, 'Yhden hengen huone', '123#', 'Kyllä'),
(124, 'Kahden hengen huone', '124#', 'Kyllä'),
(125, 'Perhehuone', '125#', 'Kyllä'),
(126, 'Sviitti', '126#', 'Kyllä');

-- --------------------------------------------------------

--
-- Table structure for table `huone_tyypit`
--

CREATE TABLE `huone_tyypit` (
  `HuoneenTyyppiID` int(11) NOT NULL,
  `Huonetyyppi` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `huone_tyypit`
--

INSERT INTO `huone_tyypit` (`HuoneenTyyppiID`, `Huonetyyppi`) VALUES
(1, 'Yhden hengen huone'),
(2, 'Kahden hengen huone'),
(3, 'Perhehuone'),
(4, 'Sviitti');

-- --------------------------------------------------------

--
-- Table structure for table `kayttajat`
--

CREATE TABLE `kayttajat` (
  `ID` int(11) NOT NULL,
  `Kayttajanimi` varchar(50) DEFAULT NULL,
  `Salasana` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kayttajat`
--

INSERT INTO `kayttajat` (`ID`, `Kayttajanimi`, `Salasana`) VALUES
(1, 'Jan Erik Lee', 'Testi123'),
(2, 'Jyri Lindroos', 'Testi123');

-- --------------------------------------------------------

--
-- Table structure for table `varaukset`
--

CREATE TABLE `varaukset` (
  `VarauksenID` int(11) NOT NULL,
  `Varaaja` varchar(100) DEFAULT NULL,
  `Huonetyyppi` varchar(50) DEFAULT NULL,
  `HuoneenNro` varchar(10) DEFAULT NULL,
  `Sisaan` date DEFAULT NULL,
  `Ulos` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `varaukset`
--

INSERT INTO `varaukset` (`VarauksenID`, `Varaaja`, `Huonetyyppi`, `HuoneenNro`, `Sisaan`, `Ulos`) VALUES
(1, 'Jyri Lindroos', 'Perhehuone', '125', '2024-03-04', '2024-03-23'),
(3, 'Jan Erik Lee', 'Yhden hengen huone', '123', '2024-03-04', '2024-03-22');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`AsiakasID`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`HuoneenNro`);

--
-- Indexes for table `huone_tyypit`
--
ALTER TABLE `huone_tyypit`
  ADD PRIMARY KEY (`HuoneenTyyppiID`);

--
-- Indexes for table `kayttajat`
--
ALTER TABLE `kayttajat`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`VarauksenID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `AsiakasID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `huoneet`
--
ALTER TABLE `huoneet`
  MODIFY `HuoneenNro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=128;

--
-- AUTO_INCREMENT for table `huone_tyypit`
--
ALTER TABLE `huone_tyypit`
  MODIFY `HuoneenTyyppiID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `kayttajat`
--
ALTER TABLE `kayttajat`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `VarauksenID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
