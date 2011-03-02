//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright (C) 2008, mEthLab Interactive
//------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Torque Game Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

// The master server is declared with the server defaults, which is
// loaded on both clients & dedicated servers.  If the server mod
// is not loaded on a client, then the master must be defined. 
// $pref::Master[0] = "2:master.garagegames.com:28002";

$pref::backgroundSleepTime = "0";
$pref::Shadows = "0.3";
$pref::EnvironmentMaps = "1";
$pref::HostMultiPlayer = "1";
$pref::HudMessageLogSize = 40;
$pref::ChatHudLength = 1;

$Pref::IRC::Name = "newbie";
$Pref::IRC::Server = "irc.freenode.net";
$Pref::IRC::Channel = "#rotc";
$Pref::IRC::ToChat::Status = true;
$Pref::IRC::ToChat::Talk = true;
$Pref::IRC::ToChat::Topic = true;
$Pref::IRC::ToChat::Users = true;

$pref::Player::Name = "/bin/cat";
$pref::Player::DefaultFov = 110;
$pref::Player::ZoomSpeed = 200;
$pref::Player::MouseZoomSteps = 3;
$pref::Player::RenderMyPlayer = 0;
$pref::Player::RenderMyItems = 1;
$Pref::Player::Trails::Amount = 5;
$Pref::Player::Trails::Detail = 0.5;
$Pref::Player::Trails::Scale = 0.125;
$Pref::Player::Trails::Visibility = 0.9;

$pref::Commander::PanSpeed = 100;
$pref::Commander::ZoomSpeed = 0.1;

$pref::Net::LagThreshold = 400;
$pref::Net::Port = 28000;
$Pref::Net::PacketSize = 450;
$Pref::Net::PacketRateToClient = 32;
$Pref::Net::PacketRateToServer = 32;

$pref::Input::MouseEnabled = 0;
$pref::Input::LinkMouseSensitivity = 1; // really used? -mag
$pref::Input::MouseSensitivity = 0.3;
$pref::Input::InvertMouse = 0;
$pref::Input::InvertMouseWhileFlying = 1;
$pref::Input::JoystickEnabled = 0;
$pref::Input::KeyboardTurnSpeed = 0.1;

$pref::sceneLighting::cacheSize = 20000;
$pref::sceneLighting::purgeMethod = "lastCreated";
$pref::sceneLighting::cacheLighting = 1;
$pref::sceneLighting::terrainGenerateLevel = 1;

$pref::ts::detailAdjust = 0.45;

$pref::Terrain::DynamicLights = 1;
$pref::Interior::TexturedFog = 0;

$pref::Video::displayDevice = "OpenGL";
$pref::Video::allowOpenGL = 1;
$pref::Video::allowD3D = 1;
$pref::Video::preferOpenGL = 1;
$pref::Video::appliedPref = 0;
$pref::Video::disableVerticalSync = 1;
$pref::Video::monitorNum = 0;
$pref::Video::windowedRes = "800 600";
$pref::Video::screenShotFormat = "PNG";

$pref::OpenGL::force16BitTexture = "0";
$pref::OpenGL::forcePalettedTexture = "0";
$pref::OpenGL::maxHardwareLights = 3;
$pref::OpenGL::textureAnisotropy = 1.0;
$pref::OpenGL::textureTrilinear = true;
$pref::VisibleDistanceMod = 1.0;

$pref::Audio::driver = "OpenAL";
$pref::Audio::forceMaxDistanceUpdate = 0;
$pref::Audio::environmentEnabled = 0;
$pref::Audio::masterVolume	= 0.8;
$pref::Audio::channelVolume1 = 0.8;
$pref::Audio::channelVolume2 = 0.8;
$pref::Audio::channelVolume3 = 0.8;
$pref::Audio::channelVolume4 = 0.8;
$pref::Audio::channelVolume5 = 0.8;
$pref::Audio::channelVolume6 = 0.8;
$pref::Audio::channelVolume7 = 0.8;
$pref::Audio::channelVolume8 = 0.8;
$pref::Audio::UseMumbleLink = 0;
