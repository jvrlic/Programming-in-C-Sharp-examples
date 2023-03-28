﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._06.Turtle5
{
    class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public double X
        {
            get;
            set;
        }
        public double Y
        {
            get;
            set;
        }
        public override string ToString()
        {
            return String.Format("X={0,6:00.0} ; Y={1,6:00.0}", X, Y);
        }
    }

    class Turtle
    {
        public Turtle()
        {
            CurrentPosition = new Point();
        }
        private double platformWidth;
        public double PlatformWidth
        {
            get { return platformWidth; }
            set
            {
                platformWidth = value;
                //EnsurePlatformSize();
            }
        }
        // The height of the platform must be between 1.0 and 10.0 inclusive
        // Values outside this range will be coerced into the range.
        private double platformHeight;
        public double PlatformHeight
        {
            get { return platformHeight; }
            set
            {
                platformHeight = value;
                //EnsurePlatformSize();
            }
        }

        private void EnsurePlatformSize()
        {
            if (PlatformWidth < 1.0)
            {
                PlatformWidth = 1.0;
            }
            if (PlatformWidth > 10.0)
            {
                PlatformWidth = 10.0;
            }
            if (PlatformHeight < 1.0)
            {
                PlatformHeight = 1.0;
            }
            if (PlatformHeight > 10.0)
            {
                PlatformHeight = 10.0;
            }
        }

        // The speed at which the motors drive the wheels,
        // in meters per second. For ease, we assume that takes account
        // of the distance traveled by the tires in contact
        // with the ground, and any slipping
        public double MotorSpeed
        {
            get;
            set;
        }
        // The state of the left motor
        public MotorState LeftMotorState
        {
            get;
            set;
        }

        // The state of the right motor
        public MotorState RightMotorState
        {
            get;
            set;
        }
        // The current position of the turtle
        public Point CurrentPosition
        {
            get;
            private set;
        }
        // The current orientation of the turtle
        public double CurrentOrientation
        {
            get;
            private set;
        }


        // Run the turtle for the specified duration
        // Returns one of the TurtleError values if a failure
        // occurs, or TurtleError.OK if it succeeds
        public void RunFor(double duration)
        {
            try
            {
                if (LeftMotorState == MotorState.Stopped && RightMotorState == MotorState.Stopped)
                {
                    // If we are at a full stop, nothing will happen
                    return;
                }
                // The motors are both running in the same direction
                // then we just drive
                if ((LeftMotorState == MotorState.Running && RightMotorState == MotorState.Running) ||
                (LeftMotorState == MotorState.Reversed && RightMotorState == MotorState.Reversed))
                {
                    Drive(duration);
                }
                // The motors are running in opposite directions,
                // so we don't move, we just rotate about the
                // center of the rig
                if ((LeftMotorState == MotorState.Running && RightMotorState == MotorState.Reversed) ||
                (LeftMotorState == MotorState.Reversed && RightMotorState == MotorState.Running))
                {
                    Rotate(duration);
                }
            }
            catch (InvalidOperationException iox)
            {
                throw new Exception("Some problem with the turtle has occurred", iox);
            }
            catch (Exception ex)
            {
                // Log here
                Console.WriteLine("Log error: " + ex.Message);
                // Rethrow
                throw;
            }
            finally
            {
                Console.WriteLine("In the Turtle finally block");
            }
        }

        private void Rotate(double duration)
        {
            if (PlatformWidth <= 0.0)
            {
                throw new InvalidOperationException("The PlatformWidth must be initialized to a value > 0.0");
            }
            // This is the total circumference of turning circle
            double circum = Math.PI * PlatformWidth;
            // This is the total distance traveled
            double d = duration * MotorSpeed;
            if (LeftMotorState == MotorState.Reversed)
            {
                // And we're going backwards if the motors are reversed
                d *= -1.0;
            }
            // So we've driven it this proportion of the way round
            double proportionOfWholeCircle = d / circum;
            // Once round is 360 degrees (or 2pi radians), so we have traveled
            CurrentOrientation = CurrentOrientation + (Math.PI * 2.0 * proportionOfWholeCircle);
            // return true; (This is now redunant, so you can delete it)
        }

        private void Drive(double duration)
        {
            // This is the total distance traveled
            double d = duration * MotorSpeed;
            if (LeftMotorState == MotorState.Reversed)
            {
                // And we're going backwards if the motors are reversed
                d *= -1.0;

            }
            // Bit of trigonometry for the change in the x,y coordinates
            double deltaX = d * Math.Sin(CurrentOrientation);
            double deltaY = d * Math.Cos(CurrentOrientation);
            // And update the position
            CurrentPosition = new Point(CurrentPosition.X + deltaX, CurrentPosition.Y + deltaY);
        }
    }
    // The current state of a motor
    enum MotorState
    {
        Stopped,
        Running,
        Reversed
    }
    enum TurtleError
    {
        OK,
        RotateError,
        MotorStateError
    }
}
