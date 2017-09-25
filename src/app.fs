module App

(**
 - title: Counter
 - tagline: The famous Increment/Decrement ported from Elm
*)

open Fable.Core
open Fable.Import
open Elmish
open System

open Fable.Core.JsInterop
open Fable.Helpers.React.Props

open Elmish.React

module R = Fable.Helpers.React

// MODEL
type Photo = {
    url: string
    }

let photos = [
         {url="1.jpeg"}
         {url= "2.jpeg"}
         {url = "3.jpeg"}
]

type Model = Photo list
    
let selectedUrl = "1.jpeg"

type Msg = | SelectedUrl

let urlPrefix = "http://elm-in-action.com/"

let viewThumbnail thumbnail =
    R.img [ Src (urlPrefix + thumbnail.url)] 
   

let init() : Model = photos


// UPDATE
let update (msg:Msg) (model:Model) =
  //match msg with 
  //| (SelectedUrl x) -> x   
    model

// VIEW (rendered with React)
let view model dispatch =
 
  R.div [] [
        //R.button [ OnClick (fun _ -> dispatch SelectedUrl) ] [ R.str "-" ]
        R.br [] 
        R.h1 [ClassName "content"] [  R.str "Photo Groove"]
        R.br []
        R.div [Id "thumbnails"] (model |> List.map viewThumbnail)     
        R.br []
        ]


// App
Program.mkSimple init update view
|> Program.withConsoleTrace
|> Program.withReact "elmish-app"
|> Program.run