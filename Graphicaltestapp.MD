| Melody Eastin |
| :---
| s198012 |
|Math for Games |
| Graphicaltestapp Documentation|

## I. Requirements

1. Description of Problem

    - **Name**: Tank game

    - **Problem Statement** 

    - **Problem Specifications** 

2. Input Information

- The keyboard is used to controle the tank

3. Output Information

4. User Interface Information


## II. Design

3. ### Object Information

    File: Actor.cs

        Description: Used for funtions that all actors have.

        **Attributes**
            
            Name: X
                Description: Used to set and get the relative x cordinate
                Type: Property

            Name: XAbsolute 
                Description: Used to get the Absolute X Coordinate.
                Type: Property
                
            Name: Y
                Description: Used to get the relative Y cordinate
                Type: Property
            
            Name: YAbsolute
                Description: Used to get the absolute Y cordinate
                Type: Property

            Name:  GetRotation
                Description: Used to get rotation of a actors
                Type: Function
            
            Name: Rotate
                Description: Used to rotate actors
                Type: Funtion

            Name: GetScale
                Description Used to get scale
                Type: Function

            Name: AddChild
                Description: Used to add child to a actor
                Type: Function

            Name: RemoveChild
                Description: Used to remove a child from parent
                Type: Function

            Name: Update Transform
                Description Used to update the transform of actors
                Type: function

    File: Tank.cs
        Descripion: Stores all functions for tank that let it move and have a hitbox
            
            **Attributes**

                Name: _texture
                    description: stores the texture for the tank
                
                Name: HitBox
                    Description: used to make hitbox for tank

                Name: Tank
                    Description: constructor used for making the tank.

                Name: MoveUp
                    Description: Used to make the tank move foward
                    Type: function

                Name: MoveBack
                    Description: Used to make the tank move back

                Name: Rotateleft
                    Description: used to rotate the tank left

                Name: RotateRight
                    Description: rotates the tank to the right

    File: Tankturrent.cs
        
        Description: Stores everything used for the tank turret and shooting

            **Attributes**
                
                Name: _Texture
                    Description: stores texture for turret

                Name: _bullets
                    Description ussed to keep you from firing to many bullets it is unused
                    Type: int

                Name: Rotateleft
                    Description: Used to rotate the turret left

                Name: Shoot
                    Description: Used to shoot bullets

    File: Bullet.cs
        
        Description: Holds functions for bullets

            **Attributes**

                Name: _texture
                    description: stores the texture for the tank

                Name: _hitBox
                    Description: used to make hitbox for tank

                Name: Bullet
                    Description: constructor used to make bullets

                Name: Ifbulletsgooffscreen
                    Description: used to check if bullet goes offscreen

                Name: Collideswithtank
                    Description: Used to detect if collision with tank2's  hitbox happens

    File: Entity.cs
        Description: Holds functions for entity

            **Attributes**

                Name: _Velocity
                    
                Name: XVelocity
                    Description: It is used for velocity on x axis.

                Name: XAcceleration
                    Description: Used for x Acceleration
                    Type: float

                Name: YVelocity
                    Description: Used for YVelocity
                    Type: float

                Name: YAcceleration
                    Description: Ussed for Y Acceleration
                    Type: float

                Name: Entity
                    Description: Constructor used to make entity
                    Type: Constructor

                Name: Update
                    Description: Used for updateing each Entity

    File: AABB.CS
        Description: used for hitboxes

            **Attributes**

                Name: _color
                    Description: Used for colors on hitboxes

                Name: Width
                    Description: Used to store the width of the hitbox

                Name: Height
                    Description: Used to store the height of the hitbox

                Name: Top
                    Description: Used to get the Top of the hitbox

                Name: Bottom
                    Description: Used to get the Bottom of the hitbox

                Name: Left
                    Description: Used to get the left side of the hitbox

                Name: Right
                    Description: Used to get the right side of the hitbox

                Name: AABB
                    Description: Constructor for hitbox

                Name: DetectCollision
                    Description: USed to detect Collision with other hitbox

                Name: Draw
                    Description: used to draw hitboxes.

    Name: Sprite

        Description: Used for making sprites

            **Attributes
                Name: _texture
                    Description: used to store texture

                Name: _image
                    Description: used to store image

                Name: Width
                    Description: used to get the width of the texture

                Name: Height
                    Description: used to get the height of the texture

                Name: Sprite
                    Description: Constructor used to get

                Name: Draw
                    Description: Used to draw the Sprite


    Name: Timer

        Description: used for calculating delta time

            **Attributes**

                Name:_stopwatch
                    Description: used to keep track of time

                Name: Timer
                    Description: used to start the stopwatch

                Name: Restart
                    Description Restarts the stopwatch

                Name: Seconds
                    Description: used to get the stopwatch time in seconds

                Name: GetDeltaTime
                    Description: used to get deltatime

    Name: Input

        Description: used for getting input

            **Attributes**

                Name: IsKeyPressed
                    Description: used to see if a key is pressed

                Name: IsKeyDown
                    Description: used to see if the key is down

                Name: IsKeyReleased
                    Description: used to see if key is released

                Name: IsKeyUp
                    Description: used to see if the key is up

    Name: Game

        Description: used to run the game

            **Attributes**

                Name: _Root
                    Description:

                Name: _next
                    Description: stores the next root actor

                Name: _gameTimer
                    Description: the timer for the game

                Name: Width
                    Description stores the games width

                Name: Height
                    Description: used to store the games height

                Name: Game
                    Description Constructor used to start the game

                Name: Run
                    Description: Function the runs the game

    Name: Matrix3.cs

        Description: used for Matrix

            **Attributes**

                Name: Matrix3
                    Description: Constructor used to make a matrix3
                    
                Name: Matrix3
                    Description: Constructor used to make a matrix3

                Name: Matrix3
                    Description: Constructor

                Name: Matrix3 *
                    Description: Used for matrix multiplication

                Name: SetScaled
                    Description: sets the scale

                Name: SetScaled
                    Description: sets the scale of a object

                Name: Set
                    Description: Sets the matrix

                Name:Set
                    Description: Sets the matrix using another matrix

                Name: Scale
                    Description: used to set the scale

                Name: Scale
                    Desciption: used to set the scale using a vector3

                Name: SetRotateX
                    Description: Used to set the rotate for x

                Name: RotateX
                    Description: used to rotate x

                Name: SetRotateY
                    Description: used to set rotate Y

                Name: RotateY
                    Description: used to rotate y

                Name: SetRotateZ
                    Description: used to set Rotate z

                Name: rotateZ
                    Description: used to rotate z

                Name: GetTransposed
                    Description: gets transposed

                Name: SetTranslation
                    Description: sets the translation

                Name: Translation
                    Description: used for translation

                Name: SetEuler
                    Description:

                Name: Vector3 *
                    Description: used to multiply a vector3 time a matrix3
    Name: Vector3
        
        Description used for doing math with vectors

            **Attributes**

                Name: Vector3
                    Description: Constructor used to make a vector3

                Name: Vecor3
                    Description: Constructor used to make a vector3

                Name: +
                    Description: Used to add vectors

                Name: -
                    Description: Used to subtract vectors

                Name: *
                    Description: used to multiply vectors

                Name: *
                    Description: used to multiply vectors

                Name: /
                    Description:used to divide vectors

                Name: /
                    Description: used to divide vectors

                Name: Magnitude
                    Description: Used to find the magnitude of the vector

                Name:  Magnitudesgr
                    Description: Used to find the magnitude of the vector

                Name: Distance
                    Discription: used to find distance between vectors

                Name: Normalize
                    Discription: used to normalize the vector

                Name: Get Normalised
                    Discription: get the normalized vector without normalizing it

                Name: DotProduc
                    Description: used to get the dot product

                Name: Dot
                    Description:

                Name: Cross
                    Description:

                Name: ToString
                    Description:

                Name: min
                    Description:
                    
                Name: Max
                    Description:

                Name: Clamp
                    Description
