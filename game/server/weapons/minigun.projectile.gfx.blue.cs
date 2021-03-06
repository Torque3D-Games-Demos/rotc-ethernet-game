//------------------------------------------------------------------------------
// Revenge Of The Cats: Ethernet
// Copyright notices are in the file named COPYING.
//------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// projectile particle emitter

datablock ParticleData(BlueMinigunProjectileParticleEmitter_Particles)
{
	dragCoefficient      = 1;
	gravityCoefficient   = 0.0;
	windCoefficient      = 0.0;
	inheritedVelFactor	= 0.0;
	constantAcceleration = 0.0;
	lifetimeMS			   = 30;
	lifetimeVarianceMS	= 0;
	spinRandomMin        = 0;
	spinRandomMax        = 0;
	textureName			   = "share/textures/rotc/corona";
	colors[0]            = "0.0 0.0 1.0 0.05";
	colors[1]            = "0.0 0.0 1.0 0.0";
	sizes[0]             = 5.0;
	sizes[1]             = 5.0;
	times[0]             = 0.0;
	times[1]             = 1.0;
	useInvAlpha          = false;
	renderDot            = false;
};

datablock ParticleEmitterData(BlueMinigunProjectileParticleEmitter)
{
	ejectionPeriodMS = 1;
	periodVarianceMS = 0;
	ejectionVelocity = 0;
	velocityVariance = 2.5;
	ejectionOffset   = 0.0;
	thetaMin         = 0;
	thetaMax         = 0;
	phiReferenceVel  = 0;
	phiVariance      = 0;
	overrideAdvances = false;
	orientParticles  = false;
	//lifetimeMS		 = 1000;
	particles = "BlueMinigunProjectileParticleEmitter_Particles";
};

//-----------------------------------------------------------------------------
// laser tail...

datablock LaserBeamData(BlueMinigunProjectileLaserTail)
{
	hasLine = true;
	lineStartColor	= "1 1 1 0.0";
	lineBetweenColor = "1 1 1 0.5";
	lineEndColor	  = "1 1 1 0.0";
	lineWidth		  = 2.0;

	hasInner = true;
	innerStartColor = "0 0 1 0.0";
	innerBetweenColor = "0 0 1 1.0";
	innerEndColor = "0 0 1 0.0";
	innerStartWidth = "0.00";
	innerBetweenWidth = "0.05";
	innerEndWidth = "0.00";

	hasOuter = true;
	outerStartColor = "0 0 1 0.0";
	outerBetweenColor = "0 0 1 1.0";
	outerEndColor = "0 0 1 0.0";
	outerStartWidth = "0.05";
	outerBetweenWidth = "0.2";
	outerEndWidth = "0.05";

	bitmap = "share/shapes/rotc/weapons/blaster/lasertail.blue";
	bitmapWidth = 0.20;
//	crossBitmap = "share/shapes/rotc/weapons/blaster/lasertail.red.cross";
//	crossBitmapWidth = 0.10;

	betweenFactor = 0.9;
	blendMode = 1;
};

//-----------------------------------------------------------------------------
// laser trail

datablock MultiNodeLaserBeamData(BlueMinigunProjectileLaserTrail)
{
	hasLine = false;
	lineColor	= "1.00 1.00 1.00 0.02";

	hasInner = false;
	innerColor = "0.00 1.00 0.00 1.00";
	innerWidth = "0.05";

	hasOuter = false;
	outerColor = "1.00 1.00 1.00 0.02";
	outerWidth = "0.05";

	bitmap = "share/textures/rotc/miniguntrail";
	bitmapWidth = 0.2;

	blendMode = 1;
 
    windCoefficient = 0.0;

    // node x movement...
    nodeMoveMode[0]     = $NodeMoveMode::None;
    nodeMoveSpeed[0]    = -0.002;
    nodeMoveSpeedAdd[0] =  0.004;
    // node y movement...
    nodeMoveMode[1]     = $NodeMoveMode::None;
    nodeMoveSpeed[1]    = -0.002;
    nodeMoveSpeedAdd[1] =  0.004;
    // node z movement...
    nodeMoveMode[2]     = $NodeMoveMode::ConstantSpeed;
    nodeMoveSpeed[2]    = 0.5;
    nodeMoveSpeedAdd[2] = 1.0;

	nodeDistance = 3;
 
	fadeTime = 1000;
};

//-----------------------------------------------------------------------------
// impact...

datablock ParticleData(BlueMinigunProjectileImpact_Smoke)
{
	dragCoeffiecient	  = 1.0;
	gravityCoefficient	= -0.0;
	inheritedVelFactor	= 0.0;

	lifetimeMS			  = 500;
	lifetimeVarianceMS	= 200;

	useInvAlpha =  false;

	textureName = "share/textures/rotc/corona4";

	colors[0]	  = "1.0 1.0 1.0 1.0";
	colors[1]	  = "0.0 0.0 1.0 0.0";
	sizes[0]		= 1.0;
	sizes[1]		= 0.0;
	times[0]		= 0.0;
	times[1]		= 1.0;

	allowLighting = false;
   renderDot = false;
};

datablock ParticleEmitterData(BlueMinigunProjectileImpact_SmokeEmitter)
{
	ejectionPeriodMS = 5;
	periodVarianceMS = 0;
	ejectionVelocity = 3;
	velocityVariance = 0;
	ejectionOffset	= 0.0;
	thetaMin			= 80;
	thetaMax			= 80;
	phiReferenceVel  = 0;
	phiVariance		= 360;
	overrideAdvances = false;
	orientParticles  = false;
	lifetimeMS		 = 50;
	particles = "BlueMinigunProjectileImpact_Smoke";
};

datablock DebrisData(BlueMinigunProjectileImpact_Debris)
{
	// shape...
	shapeFile = "share/shapes/rotc/misc/debris1.white.dts";

	// bounce...
	staticOnMaxBounce = true;
	numBounces = 5;

	// physics...
	gravModifier = 2.0;
	elasticity = 0.6;
	friction = 0.1;

	// spin...
	minSpinSpeed = 60;
	maxSpinSpeed = 600;

	// lifetime...
	lifetime = 4.0;
	lifetimeVariance = 1.0;
};

datablock ExplosionData(BlueMinigunProjectileImpact)
{
	soundProfile	= MinigunProjectileImpactSound;

	lifetimeMS = 300;

 	// shape...
	//explosionShape = "share/shapes/rotc/weapons/blaster/projectile.impact.blue.dts";
	faceViewer = false;
	playSpeed = 0.4;
	sizes[0] = "1 1 1";
	sizes[1] = "1 1 1";
	times[0] = 0.0;
	times[1] = 1.0;

	emitter[0] = DefaultSmallWhiteDebrisEmitter;
	emitter[1] = BlueMinigunProjectileImpact_SmokeEmitter;

	//debris = BlueMinigunProjectileImpact_Debris;
	//debrisThetaMin = 0;
	//debrisThetaMax = 60;
	//debrisNum = 1;
	//debrisNumVariance = 1;
	//debrisVelocity = 10.0;
	//debrisVelocityVariance = 5.0;

	// Dynamic light
	lightStartRadius = 4;
	lightEndRadius = 0;
	lightStartColor = "0.0 0.0 1.0 1.0";
	lightEndColor = "0.0 0.0 1.0 1.0";
   lightCastShadows = false;

	shakeCamera = false;
};

//-----------------------------------------------------------------------------
// hit enemy...

datablock ParticleData(BlueMinigunProjectileHit_Particle)
{
	dragCoefficient    = 0.0;
	windCoefficient    = 0.0;
	gravityCoefficient	= 0.0;
	inheritedVelFactor	= 0.0;

	lifetimeMS			  = 500;
	lifetimeVarianceMS	= 0;

	useInvAlpha =  false;

	textureName	= "share/textures/rotc/star1";

	colors[0]	  = "1.0 1.0 1.0 1.0";
	colors[1]	  = "0.0 0.0 1.0 1.0";
	colors[2]	  = "0.0 0.0 1.0 0.0";
	sizes[0]		= 0.5;
	sizes[1]		= 0.5;
	sizes[2]		= 0.5;
	times[0]		= 0.0;
	times[1]		= 0.5;
	times[2]		= 1.0;

	allowLighting = false;
	renderDot = true;
};

datablock ParticleEmitterData(BlueMinigunProjectileHit_Emitter)
{
	ejectionOffset	= 0;

	ejectionPeriodMS = 40;
	periodVarianceMS = 0;

	ejectionVelocity = 0.0;
	velocityVariance = 0.0;

	thetaMin			= 0.0;
	thetaMax			= 60.0;

	lifetimeMS		 = 100;

	particles = "BlueMinigunProjectileHit_Particle";
};

datablock ExplosionData(BlueMinigunProjectileHit)
{
	soundProfile = MinigunProjectileHitSound;

	lifetimeMS = 450;

	particleEmitter = BlueMinigunProjectileHit_Emitter;
	particleDensity = 1;
	particleRadius = 0;

	// Dynamic light
	lightStartRadius = 2;
	lightEndRadius = 0;
	lightStartColor = "0.0 0.0 1.0";
	lightEndColor = "0.0 0.0 0.0";
    lightCastShadows = false;
};

