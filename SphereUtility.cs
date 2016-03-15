﻿using UnityEngine;

public class SphereUtility
{
	public static Vector3 Position(Vector3 x_axis, Vector3 y_axis, Vector3 z_axis, float phi, float theta)
	{
		Vector3 x = x_axis * Mathf.Sin(phi) * Mathf.Cos(theta);
		Vector3 y = y_axis * Mathf.Sin(phi) * Mathf.Sin(theta);
		Vector3 z = z_axis * Mathf.Cos(phi);
		return x + y + z;
	}
	public static Vector3 Normal(Vector3 x_axis, Vector3 y_axis, Vector3 z_axis, float phi, float theta)
	{
		Vector3 x = x_axis * -Mathf.Cos(phi) * Mathf.Cos(theta);
		Vector3 y = y_axis * -Mathf.Cos(phi) * Mathf.Sin(theta);
		Vector3 z = z_axis *  Mathf.Sin(phi);
		return x + y + z;
	}
	/*
	public static void Accelerate(ref float phi, ref float theta, ref float vertical_velocity, ref float horizontal_velocity)
	{
		//eq 73 doesn't work http://mathworld.wolfram.com/SphericalCoordinates.html unless I change my definition of x velocity
		//y_position does not depend on x_position, but x_position depends on y_position
		//x_position(t, y_position)
		//y_position(t)
		//maybe using the angular version of x_velocity would work better in the long run? I will assume for now that it won't, though

		velocity_x = distance travelled per second
		velocity_y = distance travelled per second aka radians per second

		..... BEGIN SHITTY_ATTEMPT

		median_y_radius(position_y1, position_y2) //median isn't the best word
		{
			float y1_sign = System.Math.Sign(position_y1 - Mathf.PI / 2);
			float y2_sign = System.Math.Sign(position_y2 - Mathf.PI / 2);

			if(y1_sign*y2_sign == -1) //this probably isn't necessary if I use real integration
			{
				//there is a subtle integration bug here, since the radii are strictly averaged
				return ( median_y_radius(position_y1, Mathf.PI / 2) + median_y_radius(Mathf.PI / 2, position_y2) ) / 2; 
			}

			float radius1 = Radius(position_y1);
			float radius2 = Radius(position_y2);

			//?

			return median_radius;
		}

		position_x = position_x_o + median_y_radius*2*PI/velocity_x*delta_time;
		position_y = position_y_o + velocity_y*delta_time;

		..... END SHITTY_ATTEMPT

		1/(b-a)*Integral(a,b)[Sin(phi)]d_phi <-- mean value theorem doesn't work perfectly because of acceleration...

		//a = position_y;
		//b = position_y + velocity_y*delta_time;

		goes to

		?

		//https://www.niksula.hut.fi/~hkankaan/Homepages/gravity.html //Man, I always bring out this link...
		velocity_x += traction   * delta_time / 2; //If I wanted to be more precise/fancy, I could factor the change of velocity_x into IntegrateX //Okay, so maybe "I" couldn't
		velocity_y += gravity    * delta_time / 2; //I think we need some RK4 up in here... //not really, I don't think it works by virtue of not being a time-exclusive derivative
		position_x += IntegrateX(delta_time, velocity_x, position_y, velocity_y);
		position_y += velocity_y * delta_time;
		velocity_x += traction   * delta_time / 2;
		velocity_y += gravity    * delta_time / 2;

		//Seriously, why am I doing this to myself? With enough frame-rate no sane person would notice...
		//sleeping on it...

		//Maybe I can do 1/(Integral(a,b)[P(x)]dx)*Integral(a,b)[P(x)*E(x)]]d_x
		// instead of 1/(b-a)*Integral(a,b)[1*E(x)]]d_x
		// which means the equation might be:
		// 1/(vel_y*pos_y + 2*vel_y*pos_y*pos_y)*Integral(a,b)[(vel_y + vel_y*pos_y)*E(x)]]d_x

		//this, the way I see it now, is a way of weighting the distribution,
		// sort of like how you can get the moment of inertia by Integral(a,b)[Mass(x)*DistanceFromCenter(x)]dx

		//I need a probability distribution function that generates the fraction of time spent in a given position during freefall...
		// while the original equation might be it, I sort of doubt it.

		//by "probability distribution function" I probably don't mean probability density or mass functions since I doubt everything will add conveniently up to 1
		// since timestamps are variable (from .02s to .1s to ?)

		//likely turn of events: use delta = vel_o*t + .5*a*t*t as a density function where vel_xo*t (mostly(?)) "drops out"
		// this is because delta is a representation (if I'm right) of what thin slice of space a particle occupies at time t.
		// I might have to take a reciprocal or something, though

		//End bullshit math
	}
	*/
}