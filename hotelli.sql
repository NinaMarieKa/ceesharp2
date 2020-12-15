-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 15.12.2020 klo 06:42
-- Palvelimen versio: 10.4.16-MariaDB
-- PHP Version: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `asiakasID` int(10) NOT NULL,
  `Ktunnus` varchar(25) NOT NULL,
  `Etunimi` varchar(20) NOT NULL,
  `Sukunimi` varchar(50) NOT NULL,
  `Lahiosoite` varchar(50) NOT NULL,
  `Postinumero` varchar(10) NOT NULL,
  `Postitoimipaikka` varchar(25) NOT NULL,
  `Salasana` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`asiakasID`, `Ktunnus`, `Etunimi`, `Sukunimi`, `Lahiosoite`, `Postinumero`, `Postitoimipaikka`, `Salasana`) VALUES
(1, '', 'yllapitaja', 'admin', '', '', '0', 'yllapitaja'),
(2, 'admin', 'yllapitaja', 'admin', 'kotikatu 6', '12345', '0', 'admin'),
(3, 'Kokkola', 'matmei', 'Matti', 'Meikäläinen', 'Kotikatu 7', '12345', 'matmei'),
(4, 'matmei', 'Matti', 'Meikäläinen', 'Kotikatu 6', '12345', 'Kokkola', 'matmei'),
(5, 'nina', 'yksi', 'henkilö', 'hallintokatu ', '12345', 'vantaa', 'nina'),
(6, 'testi', 'testi', 'testi', 'testi', '12345', 'testi', 'testi'),
(7, 'yllapitaja', '', '', '', '0', '', 'yllapitaja'),
(8, '', '1', 'testi', 'yllapitaja', 'admin', '', '0');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `numero` int(11) NOT NULL,
  `tyyppi` int(11) NOT NULL,
  `puhelin` varchar(100) NOT NULL,
  `vapaa` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`numero`, `tyyppi`, `puhelin`, `vapaa`) VALUES
(1, 1, '0512345677', 'Kyllä'),
(2, 2, '0512345677', 'Kyllä'),
(3, 3, '133334354', 'Kyllä'),
(4, 4, '21324353', 'Kyllä');

-- --------------------------------------------------------

--
-- Rakenne taululle `huone_tyypit`
--

CREATE TABLE `huone_tyypit` (
  `idHuonetyyppi` int(11) NOT NULL,
  `tyyppi` varchar(200) NOT NULL,
  `hinta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `huone_tyypit`
--

INSERT INTO `huone_tyypit` (`idHuonetyyppi`, `tyyppi`, `hinta`) VALUES
(1, 'Yhden hengen huone', '200'),
(2, 'Kahden hengen huone', '350'),
(3, 'Perhehuone', '500'),
(4, 'Sviitti', '1000');

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `varausNumero` int(11) NOT NULL,
  `huoneenNumero` int(11) NOT NULL,
  `asiakasNumero` int(11) NOT NULL,
  `sisaanKirj` date NOT NULL,
  `ulosKirj` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`asiakasID`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`numero`),
  ADD KEY `fk_tyyppi_id` (`tyyppi`);

--
-- Indexes for table `huone_tyypit`
--
ALTER TABLE `huone_tyypit`
  ADD PRIMARY KEY (`idHuonetyyppi`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`varausNumero`),
  ADD KEY `fk_huoneen_numero` (`huoneenNumero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `asiakasID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `huone_tyypit`
--
ALTER TABLE `huone_tyypit`
  MODIFY `idHuonetyyppi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `varausNumero` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `fk_tyyppi_id` FOREIGN KEY (`tyyppi`) REFERENCES `huone_tyypit` (`idHuonetyyppi`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Rajoitteet taululle `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `fk_huoneen_numero` FOREIGN KEY (`huoneenNumero`) REFERENCES `huoneet` (`numero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
