## 🔍 Research & Learn
---
#### What are the basic elements and syntax of XAML?
XAML (eXtensible Application Markup Language) is a declarative language used to design UIs in WPF.
Key elements
* Elements: Represent UI controls (`<Button>`, `<Tesxtbox>`, `<Grid>`)
* Attributes/Properties: Configure apperance and behavior
* nested structure: Defines layout hierarchy

Example:
```csharp
<Button Content="Click me" Width="100" Height="30" />
```

#### How do layout panels like Grid, StackPanel, and DockPanel function?
##### Grid:
* Most flexible layout panel
* Uses rows and columns
* Ideal for responsive layouts

```csharp
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>
</Grid>
```
##### StackPanel:
* Arranges elements vertically or horizontally
* Simple and easy to use

```csharp
<StackPanel Orientation="Vertical">
    <Button Content="OK" />
    <Button Content="Cancel" />
</StackPanel>
```

##### DockPanel
* Docks controls to edges (Top, Bottom, Left, Right)
* Remaining space can be filled by last element

```csharp
// My own example keep the input and button to load data in the same row
<!-- Input and button -->
<DockPanel Grid.Row="1" LastChildFill="False">
    <TextBox Name="txtCarpeta"
             Width="Auto"
             MinWidth="150"
             Height="32"
             Margin="0,0,8,0"
             VerticalContentAlignment="Center"
             Background="#3A3A3A"
             BorderThickness="0"
             Padding="5"
             DockPanel.Dock="Left"
             ToolTip="Ruta de carpeta de música"/>
    <Button Name="btnCargar"
            Content="Cargar"
            Width="Auto"
            MinWidth="90"
            Height="32"
            Background="#007ACC"
            Foreground="White"
            BorderThickness="0"
            Padding="10,0"
            Cursor="Hand"
            Click="btnCargar_Click"/>
</DockPanel>
```

#### What properties and events are commonly used with WPF controls?
##### Common Properties and Events in WPF Controls
##### Properties:
* Width, Height
* Margin, Padding
* Background, Foreground
* HorizontalAlignment, VerticalAlignment

##### Events:
* Click (Button)
* TextChanged (TextBox)
* Loaded

## 📝 Reflection
---
#### What properties and events are commonly used with WPF controls?
Grid offers greater control and capacity, while StackPanel is ideal for simple layouts. Using both increases the flexibility and organization of the interface.

#### What challenges might arise when building responsive UIs with XAML?
* Managing size behaviors is more complex than in web frameworks.
* Excessive use of fixed sizes instead of flexible ones like (*, Auto).
* Deep nesting often negatively impacts readability.

#### How does separating UI and logic benefit application development?
Using XAML for the user interface and C# for logic greatly improves maintainability and readability, avoiding the spaghetti code of having functional code embedded in the frontend.

## 🛠️ Task
---
#### Create a simple XAML file demonstrating the use of at least two different layout panels.

##### Copy of a lyrics search app I created, Some comments or variables are in Spanish (My native language)

Copy of the interface in Root Project/code/xaml-basic.xaml

```csharp
<Window x:Class="LRC_App.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:LRC_App"
        mc:Ignorable="d"
        Title="LRC Finder" Height="500" Width="900"
        MinHeight="450" MinWidth="750"
        Background="#1E1E1E" Foreground="White">

    <Grid Margin="10">
        <!-- Columnas principales -->
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto" MinWidth="280" MaxWidth="400"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>

        <!-- Panel izquierdo -->
        <Border Grid.Column="0"
                CornerRadius="10"
                Background="#2D2D30"
                Padding="20"
                Margin="0,0,10,0">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <!-- Título -->
                    <RowDefinition Height="Auto"/>
                    <!-- Carpeta y botón -->
                    <RowDefinition Height="Auto"/>
                    <!-- Separador -->
                    <RowDefinition Height="Auto"/>
                    <!-- Estado -->
                    <RowDefinition Height="Auto"/>
                    <!-- Barra progreso -->
                    <RowDefinition Height="*"/>
                    <!-- Espaciador -->
                    <RowDefinition Height="Auto"/>
                    <!-- Resumen -->
                </Grid.RowDefinitions>

                <!-- Título -->
                <TextBlock Grid.Row="0"
                           Text="🎵 Cargar carpeta de música"
                           FontSize="16"
                           FontWeight="Bold"
                           Margin="0,0,0,15"
                           TextWrapping="Wrap"/>

                <!-- Input + botón -->
                <DockPanel Grid.Row="1" LastChildFill="False">
                    <TextBox Name="txtCarpeta"
                             Width="Auto"
                             MinWidth="150"
                             Height="32"
                             Margin="0,0,8,0"
                             VerticalContentAlignment="Center"
                             Background="#3A3A3A"
                             BorderThickness="0"
                             Padding="5"
                             DockPanel.Dock="Left"
                             ToolTip="Ruta de carpeta de música"/>
                    <Button Name="btnCargar"
                            Content="Cargar"
                            Width="Auto"
                            MinWidth="90"
                            Height="32"
                            Background="#007ACC"
                            Foreground="White"
                            BorderThickness="0"
                            Padding="10,0"
                            Cursor="Hand"
                            Click="btnCargar_Click"/>
                </DockPanel>

                <Separator Grid.Row="2" Margin="0,15,0,15" Background="#444"/>

                <!-- Estado -->
                <StackPanel Grid.Row="3" Orientation="Vertical">
                    <TextBlock Text="Estado de búsqueda:" FontWeight="Bold"/>
                    <TextBlock Name="txtEstadoAPI"
                               Text="Esperando..."
                               FontStyle="Italic"
                               Foreground="#CCCCCC"
                               Margin="0,3,0,10"
                               TextWrapping="Wrap"/>
                </StackPanel>

                <!-- Barra de progreso -->
                <ProgressBar Grid.Row="4"
                             Name="progressAPI"
                             Height="22"
                             Minimum="0"
                             Maximum="100"
                             Value="0"
                             Foreground="#007ACC"
                             Background="#444"
                             Margin="0,0,0,10"/>

                <!-- Espaciador flexible -->
                <Grid Grid.Row="5"/>

                <!-- Resumen -->
                <StackPanel Grid.Row="6" Orientation="Vertical">
                    <TextBlock Text="Canciones procesadas:" FontWeight="Bold"/>
                    <TextBlock Name="txtProcesadas"
                               Text="0 / 0"
                               Foreground="#AAAAAA"
                               FontSize="13"/>
                </StackPanel>
            </Grid>
        </Border>

        <!-- Panel derecho - Lista de canciones -->
        <Border Grid.Column="1"
                CornerRadius="10"
                Background="#252526"
                Padding="10">
            <ScrollViewer VerticalScrollBarVisibility="Auto">
                <ItemsControl Name="lstCanciones">
                    <ItemsControl.ItemTemplate>
                        <DataTemplate>
                            <Border Margin="0,0,0,8"
                                    Padding="8"
                                    Background="#333333"
                                    CornerRadius="6">
                                <Grid>
                                    <Grid.ColumnDefinitions>
                                        <ColumnDefinition Width="*"/>
                                        <ColumnDefinition Width="40"/>
                                    </Grid.ColumnDefinitions>

                                    <StackPanel>
                                        <TextBlock Text="{Binding titulo}" FontWeight="Bold" FontSize="14" TextTrimming="CharacterEllipsis"/>
                                        <TextBlock Text="{Binding artista}" FontStyle="Italic" Foreground="#AAAAAA" TextTrimming="CharacterEllipsis"/>
                                        <TextBlock Text="{Binding album}" Foreground="#777777" FontSize="12" TextTrimming="CharacterEllipsis"/>
                                    </StackPanel>

                                    <!-- Ícono de estado -->
                                    <TextBlock Grid.Column="1"
                                               VerticalAlignment="Center"
                                               Text="{Binding tieneLyrics, Converter={StaticResource BoolToIconConverter}}"
                                               FontSize="20"
                                               Foreground="{Binding tieneLyrics, Converter={StaticResource BoolToColorConverter}}"
                                               HorizontalAlignment="Center"/>
                                </Grid>
                            </Border>
                        </DataTemplate>
                    </ItemsControl.ItemTemplate>
                </ItemsControl>
            </ScrollViewer>
        </Border>
    </Grid>
</Window>
```