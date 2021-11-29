-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2021 at 02:59 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `property_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `properties`
--

CREATE TABLE `properties` (
  `name` varchar(26) NOT NULL,
  `area` varchar(26) NOT NULL,
  `type` varchar(26) NOT NULL,
  `price` int(10) NOT NULL,
  `availability` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `properties`
--

INSERT INTO `properties` (`name`, `area`, `type`, `price`, `availability`) VALUES
('UAP Towers', 'Gate A', 'One bedroom', 15000, 0),
('Britam Towers', 'Gate A', 'Bedsitter', 8000, 0),
('GTC Towers', 'Gate A', 'Two Bedroom', 25000, 0),
('Chrysler Building', 'Gate B', 'One bedroom', 16000, 0),
('Empire State Building', 'Gate B', 'Bedsitter', 12000, 0),
('432 Park Avenue', 'Gate B', 'Two Bedroom', 30000, 0),
('HSBC', 'Gate C', 'One bedroom', 10000, 0),
('Heron', 'Gate C', 'Bedsitter', 6000, 0),
('Citigroup', 'Gate C', 'Two Bedroom', 27000, 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
