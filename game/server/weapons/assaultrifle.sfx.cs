//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright notices are in the file named COPYING.
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// Revenge Of The Cats - assaultrifle.sfx.cs
// Sound effects for the assault rifle
//------------------------------------------------------------------------------

datablock AudioProfile(AssaultRifleFireSound)
{
	filename = "share/sounds/rotc/fire8.wav";
	description = AudioDefault3D;
	preload = true;
};

datablock AudioProfile(AssaultRifleProjectileSound)
{
	filename = "share/sounds/rotc/slide3.wav";
	description = AudioCloseLooping3D;
	preload = true;	
};

datablock AudioProfile(AssaultRifleProjectileExplosionSound)
{
	filename = "share/sounds/rotc/explosion13.wav";
	description = AudioFar3D;
	preload = true;	
};

datablock AudioProfile(AssaultRifleProjectileImpactSound)
{
	filename = "share/sounds/rotc/explosion13.wav";
	description = AudioFar3D;
	preload = true;
};

datablock AudioProfile(AssaultRifleProjectileHitSound)
{
	filename = "share/sounds/rotc/explosion13.wav";
	description = AudioFar3D;
	preload = true;
};

datablock AudioProfile(AssaultRifleProjectileBounceSound)
{
	filename = "share/sounds/rotc/bounce1.wav";
//	alternate[0] = "share/sounds/rotc/impact3-1.wav";
//	alternate[1] = "share/sounds/rotc/impact3-2.wav";
//	alternate[2] = "share/sounds/rotc/impact3-3.wav";
//	alternate[3] = "share/sounds/rotc/ricochet2-1.wav";
//	alternate[4] = "share/sounds/rotc/ricochet2-1.wav";
//	alternate[5] = "share/sounds/rotc/ricochet2-1.wav";
	description = AudioClose3D;
	preload = true;
};

datablock AudioProfile(AssaultRifleProjectileMissedEnemySound)
{
	filename = "share/sounds/rotc/flyby1.wav";
	description = AudioClose3D;
	preload = true;
};


