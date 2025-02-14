# Process Journal

## 23/01/25 | Make a thing assignment!

I've been thinking about ideas of faith, trust, and darkness this week, so that's what I decided to focus on for this first assignment.

I did admittedly have a busy week for non-school reasons, so this was a very quick thing.
I also haven't really used Bitsy for too long yet, so I wanted to start learning how it works.

I began with the idea of a previous Twine project I made where I tried to make links that blended in with the background and took attention to see.
I then tried to apply this to a lock and key system, which seems to be a core functionality in Bitsy.
Thus I came up with the idea of progressing through rooms with progressively harder to see objects one must gather to continue

In the end, I ended up spending too long figuring out how locks worked in Bitsy, and was only able to make two rooms, not allowing for much a "difficulty curve"

Still, I do feel like I have a better idea of how the tool works! Plus, it was nice to get to write a bit and make little sprites.

[game: Have Faith](https://github.com/eclectic-kitty/cart-315/tree/main/projects/makeAThing)

## 28/01/25 | Unity Exploration No. 1

I was watching a video on how the gravity in Super Mario Galaxy works and now I'm a bit curious about messing around with gravity, although I'm guessing that's something we'll look at in another week.

List of mechanics/features we looked at w/ possible experimentation directions
- Moving with keyboard keys
  - friction & slip?
  - ramp up?
  - run button?
  - joystick controls?
  - what if speed is jittery?
- collision detection
  - powerup to expand collision mask, ie make collector bigger
  - Add floor
    - items bounce!
- sprites
  - I wanna mess with the sprites somehow
  - Sprites that flicker to something else?
  - Sprites that scroll?
  - Sprites that have other images randomly flash over?
    - Ghostly
    - High transparecny

Process
- Starting with the sprites, giving falling items a sprite
  - For some reason my sprite is less bright in the game, probably a lighting thing?
    - Oh, it applies a color over the sprite? ok...
  - Where did this filename_0 copy come from?
    - My guess is it's a copy used for the object?
  - Okay, how would I do multiple sprites? 
    - Could I add a second sprite renderer to the same object? No :'(
    - Oh, I can add another sprite object!
    - The color can be used to manage transparency, and it looks pretty good!
  - A nested sprite mask object works nicely to keep it within the record
  - Now I want to make it flicker between different sprites.
    - List of sprites!
      - How to access different sprites from script?
      - It looks like I can make a list? and access it from the editor?
      - Or I can use a "resources" folder
      - Lists are funky in C#, curious about the <> tags, but I think I got it working!
      - For some reason, one of my sprites won't go in the list, but only problem so far!
    - Accessing sprites!
      - Welp, Sprite Renderer has a space -_-
      - Hmm, there are two randoms, making me have to specify which one...
      - Can't find the SpriteRenderer reference now...
      - App I have to use GetComponent? Strange...
      - Anyway, it's working! It's changing randomly!!!

Questions
- What's up with GetComponent?
- How do I get around there being a System.Random and a UnityEngine.Random?

## 06/02/25 | Unity Exploration No. 2

Stuff we did last week & possible directions
- 2D physics
  - Weight?
  - Bounciness?
  - Are there other parameters?
  - How can we mess with these parameters in-game?
- Sound
  - Sound coming from different places!
    - hide-and-seek?
    - hot or cold?
  - Can we do any generative sound?
  - Integrate a Max patch?
- Instancing
  - :p

Work!
- Trying to make a reference to the sprite renderer component in what I was doing last week
  - Not going well
  - Am confused
  - Do I know how to code???
  - Pain
  - (I can't quite figure out what type this variable needs to be? And looking up how to create a reference on Unity Docs is not currently being very helpful I fear)
- Abandoning that for now, like the hide-and-seek audio idea
  - Ideating
    - Spatial audio I don't think would work, given 2D, top down doesn't really make sense
    - Could modulate volume as you're closer or farther
    - could do labyrinth? Top-down?
    - Or maybe sidescrolling hiding in / behind things?
  - Set-up
  	- Made an object that can move around!
  	- Gave it audio!
  	- Accessing other objects...
  	  - Not sure I love how difficult it seems to be to do so from within scripts
  	  - Especially children!
  	  - Then again, not sure if I'm misremembering it being easier in Godot
  	  - Anyway, I'll just reference within the editor for now
  	  - Nevermind that didn't work...
  	  - That's as far as I got, alas.
  	  
## 12/02/23 | Unity Exploration No. 3
Alrighty, after being disappointed by the amouont of work I did last week, I'm devoting myself to making a Thing this week!
To keep things simple, I'm going to try and finish the idea I had last week, getting a limited aesthetics functional prototype with the following things

Features:
- Marco Polo
	- Spacebar causes player avatar to make a sound
	- It also causes the the hiding NPC to make a sound
		- This sound is attenuated by the distance between NPC and player
- Darkness
	- Only the immediate area around the player is visible
- Labyrinth
	- Walls! Lots of them!
	- Few dead ends, lots of paths
	
Having thought about this to make the list, I have ideas for potential future features I may be inclined to add and I wanna write them down so I don't forget.

Potential future ideas:
- Labyrinth
	- Wrap around
	- Specific spots that teleport the player
	- Labyrinth changes around player
	- Impossible spaces
	- Drastic changes in scale
	- A lot of these would probably require a camera that follows the player
- Marco Polo
	- Sound attenuated also by walls?
		- Or by pathfinding?
	- Different parts of the labyrinth have different quality?
		- Organic walls muffle sound more
	- Muffling in general! Different parts of a sound travel differently
	- Giving NPC ways of trying to trick the player...
- Darkness
	- Torches/fuel system...
		- Player starts to get disturbing effects, hallucinations, etc. 
		
Work:
- Reading player's distance
	- Attempting to use singleton method worked!
	- My autocomplete seems to be mostly broken, but alas. (it's not even automatically bracketing things? Debug.Log() isn't changing colour???)
	- In any case, i can read either my xLoc, yLoc variables, or transform.position so that's p cool.
	- Distance is simple with a built in function in the Vector3 class!
	- Still don't really understand what the hecc IEnumerator is...
	- It works!!!
    - Not well, mind u
    - The volume range Unity uses doesn't seem to be accounting for decibels being exponential I don't think?
    - The audible difference from like, 0.1 - 0.5 is not big
    - but the audible difference between 0.01 - 0.02 is
- Labyrinth
  - Oooh boy, designing and creating takes a while
  - Gotta figure out later how tiles works later. This was painful with so many different walls
  - But I have a labyrinth!

![Numerous wall objects in the unity editor](./images/WALLS.png "So many walls...")
![A labyrinth](./images/labyrinth.png "The finished labyrinth")

- uh oh, how do I make them solid...
    - Took a while to understand why the collision wasn't registering/working
      - Lots of forums online insisted the solidness would just work with the collider components
      - Then, once I realized I was going to have to handle this in the script, took a while to find out that you kinematic Rigidbodies don't register collisions with static rigidbodies...
    - Made a collision system that makes it really easy to get inside walls with reversed controls teehee
    - Following an online tutorial, used the Input component to make the player move with the RigidBody component, which then automatically collides with walls
  - Light, ie hiding everything not next to player
    - I initially tried just adding a sprite mask component to the player object... Didn't work??? Not not at all, but just, weirdly
    - In the end, I just made children
    - Discovered semi-transparency doesn't work with masks :'(
    - It's ok though, I just added an extra sprite with transparency
    - Anyway, I made a "darkness" that just overlays the entire screen but is not rendered within the mask that follows the player!

I think I'll leave it there for now. THe next thing to do would be to make the hider spawn in random places (and a win state :p) but I'm feeling pretty wiped out. I got really really stuck with the whole movement + collision thing. Also making the labyrinth the way I did was super time consuming, not to mention designing it in and of itself.

![A ball moving around a maze that is only visible around the ball](./images/labyrinthGameplay.gif "Gameplay")
