# false-gravity-with-tidal-effect
Unity's default gravity assumes that your world is flat. If your planet is round, you will need to write your own gravity. 
This script accomplishes not only gravity for a spheroidal planet, but also includes a secondary gravity source for a low-orbit moon, causing interesting tidal effects.

In a Unity scene, include an object called "planet", an object called "moon", and at least one object which you want to be affected by the gravitational pull of both the planet and the moon. 

Attach the falsegravity.cs C# script to your object and it will fall to the planet, from any direction, and also be slightly pulled on by the gravity of the moon.

A working demo of this can be seen (on Safari, Firefox, and IE only) at the following URL: https://s3-us-west-1.amazonaws.com/collapsiblemedia.com/false+gravity+with+tidal+effect+demo/false+gravity+with+tidal+effect+demo.html

NOTE: The demo example also includes some scripts controlling the rotation of the planet and the orbit of the moon. Those scripts are not included in this repository because they are simple, one-line "transform.Rotate" commands.
