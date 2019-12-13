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

        *Attributes**

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
