-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 30, 2021 at 12:23 PM
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
-- Table structure for table `forsale`
--

CREATE TABLE `forsale` (
  `area` varchar(26) NOT NULL,
  `name` varchar(26) NOT NULL,
  `type` varchar(26) NOT NULL,
  `price` int(26) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `forsale`
--

INSERT INTO `forsale` (`area`, `name`, `type`, `price`) VALUES
('Gate A', 'UAP towers', 'Studio', 13000),
('Gate A', 'GTC Tower', 'Bedsitter', 7500),
('Gate A', 'Prism Tower', 'Two bedroom', 23000),
('Gate A', 'UAP towers', 'Studio', 13000),
('Gate A', 'GTC Tower', 'Bedsitter', 7500),
('Gate A', 'Prism Tower', 'Two bedroom', 23000);

-- --------------------------------------------------------

--
-- Table structure for table `rental`
--

CREATE TABLE `rental` (
  `area` varchar(26) NOT NULL,
  `name` varchar(26) NOT NULL,
  `type` varchar(26) NOT NULL,
  `price` int(26) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
