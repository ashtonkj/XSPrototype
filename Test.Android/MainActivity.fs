﻿namespace Test.Android

open System

open Android.App
open Android.Content
open Android.OS
open Android.Runtime
open Android.Views
open Android.Widget

[<Activity (Label = "Test", MainLauncher = true)>]
type MainActivity () =
    inherit Xamarin.Forms.Platform.Android.AndroidActivity ()
    override this.OnCreate (bundle) =

        base.OnCreate (bundle)

        Xamarin.Forms.Forms.Init(this,bundle)
        this.SetPage(Test.Core.App.GetMainPage())