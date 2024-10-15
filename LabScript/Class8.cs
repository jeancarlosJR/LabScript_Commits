﻿using System.Data;

using System;

< Router AppAssembly = "@typeof(App).Assembly" >
    < Found Context = "routeData" >
        < RouteView RouteData = "@routeData" DefaultLayout = "@typeof(MainLayout)" />
        < FocusOnNavigate RouteData = "@routeData" Selector = "h1" />
    </ Found >
    < NotFound >
        < PageTitle > Not found </ PageTitle >
        < LayoutView Layout = "@typeof(MainLayout)" >
            < p role = "alert" > Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
</Router>
