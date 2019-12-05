-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 04, 2019 at 03:02 AM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `food drifters`
--

-- --------------------------------------------------------

--
-- Table structure for table `foodblogpages`
--

CREATE TABLE `foodblogpages` (
  `foodblogid` int(20) UNSIGNED NOT NULL COMMENT 'PrimaryKey',
  `foodblogtitle` varchar(255) COLLATE latin1_bin DEFAULT NULL,
  `chefname` varchar(255) COLLATE latin1_bin NOT NULL,
  `foodblogbody` mediumtext COLLATE latin1_bin
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `foodblogpages`
--

INSERT INTO `foodblogpages` (`foodblogid`, `foodblogtitle`, `chefname`, `foodblogbody`) VALUES
(1, 'Biriyani', 'Micheal', 'This is a delicious Pakistani/Indian rice dish which is often reserved for very special occasions such as weddings, parties, or holidays such as Ramadan. It has a lengthy preparation, but the work is definitely worth it. For biryani, always use long grain rice. Basmati rice with its thin, fine grains is the ideal variety to use. Ghee is butter that has been slowly melted so that the milk solids and golden liquid have been separated and can be used in place of vegetable oil to yield a more authentic taste.'),
(3, 'Pickle-Fried Chicken', 'Vitaleyyyyy', 'Step 1: Place chicken thighs in a resealable plastic bag cover with pickle juice. Seal and refrigerate for 3 hours.\r\nStep 2: Drain pickle juice from thighs. Cover chicken; marinate untill ready to fry.\r\nStep 3: Preheat oven to 350 degrees F .\r\nStep 4: Heat 2 inches oil in a Dutch oven over medium-high heat to 350 degrees F.\r\nStep 5: Pour buttermilk and flour into 2 separate bowls. Season flour with salt and pepper. Dredge chicken in buttermilk. Toss in flour. Return to buttermilk and toss in flour a second time. Place chicken on a rack set over a baking sheet.\r\nStep 6: Fill Dutch oven with as many thighs as possible without crowding. Cook at 350 degrees F  until golden brown, 5 to 7 minutes per side. Place thighs on the baking sheet. Repeat until all pieces are fried. Transfer thighs to the oven.\r\nStep 7: Bake in the preheated oven until no longer pink in the center and the juices run clear, 5 to 8 minutes. An instant-read thermometer inserted into the center should read at least 165 degrees F . Season with a pinch of salt.'),
(4, 'Lo Mein Noodles', 'SarBetEns', 'This was a blend of multiple lo mein recipes I found. Add your favorite meat for a main dish, or make as a side dish to your favorite homemade chinese dinner. If you use meat, cook the meat in the pan first, and then pull out and set aside.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `foodblogpages`
--
ALTER TABLE `foodblogpages`
  ADD PRIMARY KEY (`foodblogid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `foodblogpages`
--
ALTER TABLE `foodblogpages`
  MODIFY `foodblogid` int(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'PrimaryKey', AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
