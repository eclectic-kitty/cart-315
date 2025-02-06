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
