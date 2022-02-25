-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 24 fév. 2022 à 15:27
-- Version du serveur :  10.4.18-MariaDB
-- Version de PHP : 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `social_medias`
--

-- --------------------------------------------------------

--
-- Structure de la table `events`
--

CREATE TABLE `events` (
  `id_event` int(11) NOT NULL,
  `name_event` varchar(150) NOT NULL,
  `date_event` date NOT NULL,
  `place_event` varchar(150) NOT NULL,
  `status_event` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `events`
--

INSERT INTO `events` (`id_event`, `name_event`, `date_event`, `place_event`, `status_event`) VALUES
(1, 'Cooking', '0000-00-00', 'Casablanca', 0),
(2, 'Birthday', '0000-00-00', 'Rabat', 0),
(3, 'Personal Event', '0000-00-00', 'Florida', 1),
(4, 'Birthday Party', '0000-00-00', 'nnn', 0);

-- --------------------------------------------------------

--
-- Structure de la table `findfriends`
--

CREATE TABLE `findfriends` (
  `id_ff` int(11) NOT NULL,
  `name_ff` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `findfriends`
--

INSERT INTO `findfriends` (`id_ff`, `name_ff`) VALUES
(6, 'Hande Erçel'),
(8, 'Kerem Bursin'),
(9, 'TheDollBeauty'),
(10, 'Batman'),
(11, 'Alp Navruz'),
(12, 'SebastianOfiicial'),
(13, 'TheRock'),
(14, 'KendallJenner'),
(15, 'Damso'),
(16, 'BenjiSamat'),
(17, 'Milla Jassmine'),
(18, 'Benji Samat'),
(19, 'Renata Notni'),
(20, 'TheDollBeauty'),
(21, 'Batman'),
(22, 'Alp Navruz'),
(23, 'SebastianOfiicial'),
(24, 'TheRock'),
(25, 'KendallJenner'),
(26, 'Damso'),
(27, 'BenjiSamat'),
(28, 'Milla Jassmine'),
(29, 'Benji Samat'),
(30, 'Renata Notni');

-- --------------------------------------------------------

--
-- Structure de la table `groups`
--

CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `group_name` varchar(150) NOT NULL,
  `group_category` varchar(150) NOT NULL,
  `group_members` varchar(150) NOT NULL,
  `status_group` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `groups`
--

INSERT INTO `groups` (`id`, `group_name`, `group_category`, `group_members`, `status_group`) VALUES
(1, 'Music', 'Art', '15', 0),
(2, 'Family', 'Creativity', '30', 0),
(3, 'PaintWithMe', 'Art', '30', 1),
(4, 'Group', 'Chill', '15', 0),
(5, 'The Office', 'Business', '5', 1),
(7, 'Group', 'Design', '25', 0);

-- --------------------------------------------------------

--
-- Structure de la table `myfriends`
--

CREATE TABLE `myfriends` (
  `id_myfriend` int(11) NOT NULL,
  `name_friend` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `myfriends`
--

INSERT INTO `myfriends` (`id_myfriend`, `name_friend`) VALUES
(1, 'Lea Elad'),
(2, 'Ela Mickealson');

-- --------------------------------------------------------

--
-- Structure de la table `pages`
--

CREATE TABLE `pages` (
  `id_pages` int(11) NOT NULL,
  `name_pages` varchar(150) NOT NULL,
  `category_pages` varchar(150) NOT NULL,
  `status_pages` varchar(150) NOT NULL,
  `edit` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `pages`
--

INSERT INTO `pages` (`id_pages`, `name_pages`, `category_pages`, `status_pages`, `edit`) VALUES
(3, 'Work Page', 'Business', 'Public', 0),
(4, 'Netflix Party', 'Chill', 'Public', 1),
(5, 'Economy Page', 'Business', 'Public', 1),
(6, 'Travels', 'Cultures', 'Private', 0);

-- --------------------------------------------------------

--
-- Structure de la table `posts`
--

CREATE TABLE `posts` (
  `id` int(11) NOT NULL,
  `post` varchar(300) DEFAULT NULL,
  `status_post` tinyint(1) NOT NULL,
  `Liked` varchar(50) NOT NULL DEFAULT 'Not Liked',
  `comment` varchar(150) NOT NULL DEFAULT 'No Comment Yet !'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `posts`
--

INSERT INTO `posts` (`id`, `post`, `status_post`, `Liked`, `comment`) VALUES
(52, '\"Success usually comes to those who are too busy to be looking for it.\"', 0, 'Not Liked', 'No Comment Yet '),
(53, '\"Things work out best for those who make the best of how things work out.\" ', 0, 'Not Liked', 'No Comment Yet '),
(54, '\"If you are not willing to risk the usual, you will have to settle for the ordinary.\"', 0, 'Not Liked', 'No Comment Yet '),
(55, '“No code has zero defects.”', 0, 'Not Liked', 'No Comment Yet '),
(56, '“It’s not a bug — it’s an undocumented feature.”', 0, 'Not Liked', 'No Comment Yet '),
(57, '“In a room full of top software designers, if two agree on the same thing, that’s a majority.”', 0, 'Not Liked', 'No Comment Yet '),
(59, '“I’ve finally learned what upward compatible means. It means we get to keep all our old mistakes.”', 1, 'Not Liked', 'Good Job'),
(60, '\"Whenever you see a successful person, you only see the public glories, never the private sacrifices to reach them.\"', 1, 'Liked', 'HAHHAHHAHAA'),
(62, 'Q: What did the Java code say to the C code? A: You’ve got no class.”', 0, 'Not Liked', '“You’ll surely have fun when programming Kotlin, promised.” '),
(63, '“JavaScript logic: 0 == \"0\" and 0 == []; therefore, \"0\" != [].', 0, 'Not Liked', 'JS the best !');

-- --------------------------------------------------------

--
-- Structure de la table `registration`
--

CREATE TABLE `registration` (
  `id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `userame` varchar(50) DEFAULT NULL,
  `adressmail` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `registration`
--

INSERT INTO `registration` (`id`, `name`, `userame`, `adressmail`, `password`, `status`) VALUES
(1, 'Nada Ayoujil', 'nada', 'nada.ayoujil@gmail.com', 'nada', 1),
(2, 'Rania Alaoui', 'rania', 'rania.alaoui@gmail.com', 'rania', 0),
(3, 'Amine Fouad', 'amine', 'amine.fouad@gmail.com', 'amine', 0),
(4, 'Younes El Jjouaoui', 'younes', 'younes.eljjouaoui@gmail.com', 'younes', 0);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`id_event`);

--
-- Index pour la table `findfriends`
--
ALTER TABLE `findfriends`
  ADD PRIMARY KEY (`id_ff`);

--
-- Index pour la table `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `myfriends`
--
ALTER TABLE `myfriends`
  ADD PRIMARY KEY (`id_myfriend`);

--
-- Index pour la table `pages`
--
ALTER TABLE `pages`
  ADD PRIMARY KEY (`id_pages`);

--
-- Index pour la table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `events`
--
ALTER TABLE `events`
  MODIFY `id_event` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `findfriends`
--
ALTER TABLE `findfriends`
  MODIFY `id_ff` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT pour la table `groups`
--
ALTER TABLE `groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `myfriends`
--
ALTER TABLE `myfriends`
  MODIFY `id_myfriend` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `pages`
--
ALTER TABLE `pages`
  MODIFY `id_pages` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `posts`
--
ALTER TABLE `posts`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;

--
-- AUTO_INCREMENT pour la table `registration`
--
ALTER TABLE `registration`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
