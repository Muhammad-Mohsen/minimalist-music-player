﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MinimalistMusicPlayer
{
	class Anim
	{
        public static void AnimateHeight(FrameworkElement element, double oldValue, double newValue, double duration)
        {
			AnimateDoubleBasedProperty(element, newValue, duration, FrameworkElement.HeightProperty, true);
        }

		public static void AnimateOpacity(FrameworkElement element, double oldValue, double newValue, double duration)
		{
			AnimateDoubleBasedProperty(element, newValue, duration, UIElement.OpacityProperty, true);
		}

        // generic double animation method
        private static void AnimateDoubleBasedProperty(FrameworkElement element, double newVal, double duration, DependencyProperty prop, bool ease) 
        {
            DoubleAnimation anim = new DoubleAnimation(newVal, new Duration(TimeSpan.FromSeconds(duration)));

			if (ease)
				anim.EasingFunction = new PowerEase() { EasingMode = EasingMode.EaseInOut };

            element.BeginAnimation(prop, anim);
        }
		
		public static void AnimateAngle(FrameworkElement element, double oldValue, double newValue, double duration, bool isRepeated)
		{
			DoubleAnimation animation = new DoubleAnimation(oldValue, newValue, new Duration(TimeSpan.FromSeconds(duration)));

			if (isRepeated)
				animation.RepeatBehavior = RepeatBehavior.Forever;

			element.RenderTransform = new RotateTransform();
			element.RenderTransformOrigin = new Point(.5, .5);

			element.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
		}

		public static void StopRotationAnimation(FrameworkElement element)
		{
			element.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, null);
			element.BeginAnimation(RotateTransform.AngleProperty, null);
		}

		public static Storyboard CreateRotationStoryBoard(FrameworkElement element, double oldValue, double newValue, double duration, bool isRepeated)
		{
			Storyboard board = new Storyboard();

			DoubleAnimation animation = new DoubleAnimation(oldValue, newValue, new Duration(TimeSpan.FromSeconds(duration)));
			if (isRepeated)
				animation.RepeatBehavior = RepeatBehavior.Forever;

			// element.RenderTransform = new RotateTransform();
			// element.RenderTransformOrigin = new Point(.5, .5);

			animation.SetValue(Storyboard.TargetNameProperty, element.Name);
			animation.SetValue(Storyboard.TargetPropertyProperty, new PropertyPath("(UIElement.RenderTransform).(RotateTransform.Angle)"));

			animation.BeginTime = new TimeSpan(0, 0, 0);

			board.Children.Add(animation);

			return board;
		}
	}
}