for i in images do
        yield
            img [
                Src i.Src
                OnClick (fun _ -> dispatch (ImageClicked i.ID))]

do "yield! myFunction()" in the view

li [classList [ "active", a="a" ] ] [
   a [Href "#general"; DataToggle "tab"] [str "General"]
]


          