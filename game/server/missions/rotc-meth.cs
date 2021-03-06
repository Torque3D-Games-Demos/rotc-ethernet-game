//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright notices are in the file named COPYING.
//------------------------------------------------------------------------------

//*******************************************************
// Mission init script for ROTC: mEthMatch missions
//*******************************************************

exec("./rotc-types.cs");

$Server::MissionFile = strreplace($Server::MissionFile, 
	"/rotc-methmatch/", "/rotc-ethernet/");

exec("./rotc-eth.cs");

$Server::MissionFile = strreplace($Server::MissionFile, 
	"/rotc-ethernet/", "/rotc-methmatch/");

$Game::GameType = $Game::mEthMatch;
$Game::GameTypeString = "ROTC: mEthMatch";





		
