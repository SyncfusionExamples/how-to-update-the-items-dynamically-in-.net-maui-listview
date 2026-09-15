# How to update the items dynamically in .NET MAUI ListView (SfListView)?

This examples explains about how to refresh the view when updating source dynamically using timer.

## Sample

```xaml

 <listView:SfListView x:Name="listView" 
                        ItemSize="70" GroupHeaderSize="60" 
                        ItemsSource="{Binding ContactInfo}" ItemSpacing="0,0,5,0" >
                        
    <listView:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid x:Name="grid" RowSpacing="1">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="*" />
                            <RowDefinition Height="1" />
                        </Grid.RowDefinitions>
                        <Grid RowSpacing="1">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="50" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image Source="{Binding ContactImage}"
                                VerticalOptions="Center"
                                HorizontalOptions="Center"
                                HeightRequest="50" Aspect="AspectFit"/>
                            <Grid Grid.Column="1"
                                RowSpacing="1"
                                Padding="10,0,0,0"
                                VerticalOptions="Center">
                                <Grid.RowDefinitions>
                                    <RowDefinition Height="*" />
                                    <RowDefinition Height="*" />
                                </Grid.RowDefinitions>
                                <Label LineBreakMode="WordWrap" 
                                    TextColor="#474747"
                                    Text="{Binding ContactName}">
                                </Label>
                                <Label Grid.Row="1"
                                    Grid.Column="0"
                                    TextColor="#474747"
                                    LineBreakMode="NoWrap"
                                    Text="{Binding ContactNumber}">
                                </Label>
                            </Grid>
                        </Grid>
                        <StackLayout Grid.Row="1" BackgroundColor="Gray" HeightRequest="1"/>
                    </Grid>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </listView:SfListView.ItemTemplate>
</listView:SfListView>
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
