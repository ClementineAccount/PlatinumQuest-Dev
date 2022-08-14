<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2022/07/22 18:38:16">
    <Sunlight azimuth="180" elevation="35" color="100 100 100" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="9">
        <SceneShape id="0" type="1" entityID="2" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="3" dl="0" group="-1" locked="0" />
        <SceneShape id="2" type="1" entityID="4" dl="0" group="-1" locked="0" />
        <SceneShape id="3" type="1" entityID="5" dl="0" group="-1" locked="0" />
        <SceneShape id="4" type="1" entityID="6" dl="0" group="-1" locked="0" />
        <SceneShape id="5" type="1" entityID="7" dl="0" group="-1" locked="0" />
        <SceneShape id="6" type="1" entityID="8" dl="0" group="-1" locked="0" />
        <SceneShape id="7" type="1" entityID="9" dl="0" group="-1" locked="0" />
        <SceneShape id="8" type="1" entityID="10" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="11">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="1" classname="Door_Elevator" gametype="Torque" isPointEntity="0">
                        <Properties InitialTargetPosition="-1" datablock="PathedDefault" />
                    </Entity>
                    <Entity id="2" classname="path_node" gametype="Torque" isPointEntity="1" origin="-39 -33 14.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="3" classname="path_node" gametype="Torque" isPointEntity="1" origin="-35 -33 16" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="4" classname="path_node" gametype="Torque" isPointEntity="1" origin="-33.5 -33 20" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="5" classname="path_node" gametype="Torque" isPointEntity="1" origin="-35 -33 24" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="6" classname="path_node" gametype="Torque" isPointEntity="1" origin="-39 -33 25.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="7" classname="path_node" gametype="Torque" isPointEntity="1" origin="-43 -33 24" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="8" classname="path_node" gametype="Torque" isPointEntity="1" origin="-44.5 -33 20" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="9" classname="path_node" gametype="Torque" isPointEntity="1" origin="-43 -33 16" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                    <Entity id="10" classname="path_node" gametype="Torque" isPointEntity="1" origin="-39 -33 14.5" direction="0 -0 -0">
                        <Properties next_time="1000" smoothing="1" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="34">
                    <Brush id="17" owner="1" type="999" pos="-39 -33 14.5" rot="1 0 0 0" scale="" transform="1 0 0 -39 0 1 0 -33 0 0 1 14.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2 2 0.5" />
                            <Vertex pos="2 2 -0.5" />
                            <Vertex pos="2 -2 0.5" />
                            <Vertex pos="2 -2 -0.5" />
                            <Vertex pos="-2 2 0.5" />
                            <Vertex pos="-2 2 -0.5" />
                            <Vertex pos="-2 -2 0.5" />
                            <Vertex pos="-2 -2 -0.5" />
                        </Vertices>
                        <Face id="0" plane="1 -0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -256 0 0 -1 128 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.5" album="Blasted" material="bm_tile01_D" texgens="1 0 0 512 0 -1 0 0 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="5" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -256 0 -1 0 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-39.125 -35.25 17.125" rot="1 0 0 0" scale="" transform="1 0 0 -39.125 0 1 0 -35.25 0 0 1 17.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.375" />
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.375" />
                            <Vertex pos="-0.125 0.25 2.625" />
                            <Vertex pos="-0.125 -0.25 2.625" />
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.875" />
                        </Vertices>
                        <Face id="0" plane="-0 -0.707107 -0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 1920 1 0 0 -960 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-39.125 -35.25 22.875" rot="1 0 0 0" scale="" transform="1 0 0 -39.125 0 1 0 -35.25 0 0 1 22.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.375" />
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.375" />
                            <Vertex pos="-0.125 0.25 -2.625" />
                            <Vertex pos="-0.125 -0.25 -2.625" />
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.875" />
                        </Vertices>
                        <Face id="0" plane="0 -0.707107 0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="1 -0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 1920 1 0 0 -960 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-38.875 -35.25 17.125" rot="1 0 0 0" scale="" transform="1 0 0 -38.875 0 1 0 -35.25 0 0 1 17.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.375" />
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.375" />
                            <Vertex pos="0.125 0.25 2.625" />
                            <Vertex pos="0.125 -0.25 2.625" />
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.875" />
                        </Vertices>
                        <Face id="0" plane="-0 -0.707107 -0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 128 1 0 0 -832 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-38.875 -35.25 22.875" rot="1 0 0 0" scale="" transform="1 0 0 -38.875 0 1 0 -35.25 0 0 1 22.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.375" />
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.375" />
                            <Vertex pos="0.125 0.25 -2.625" />
                            <Vertex pos="0.125 -0.25 -2.625" />
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.875" />
                        </Vertices>
                        <Face id="0" plane="0 -0.707107 0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 128 1 0 0 -832 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-41.875 -35.25 19.875" rot="1 0 0 0" scale="" transform="1 0 0 -41.875 0 1 0 -35.25 0 0 1 19.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.375 -0.25 -0.125" />
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.375 -0.25 0.125" />
                            <Vertex pos="2.625 0.25 -0.125" />
                            <Vertex pos="2.625 -0.25 -0.125" />
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.875 -0.25 0.125" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 192 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0 -1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 3264 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3648 0 1 0 1920 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-36.125 -35.25 19.875" rot="1 0 0 0" scale="" transform="1 0 0 -36.125 0 1 0 -35.25 0 0 1 19.875 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.375 -0.25 -0.125" />
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.375 -0.25 0.125" />
                            <Vertex pos="-2.625 0.25 -0.125" />
                            <Vertex pos="-2.625 -0.25 -0.125" />
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.875 -0.25 0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 6208 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3648 0 1 0 1920 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-41.875 -35.25 20.125" rot="1 0 0 0" scale="" transform="1 0 0 -41.875 0 1 0 -35.25 0 0 1 20.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.375 -0.25 0.125" />
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.375 -0.25 -0.125" />
                            <Vertex pos="2.625 0.25 0.125" />
                            <Vertex pos="2.625 -0.25 0.125" />
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.875 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 64 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 3264 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0.707107 -0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3776 0 1 0 2432 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="-36.125 -35.25 20.125" rot="1 0 0 0" scale="" transform="1 0 0 -36.125 0 1 0 -35.25 0 0 1 20.125 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.375 -0.25 0.125" />
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.375 -0.25 -0.125" />
                            <Vertex pos="-2.625 0.25 0.125" />
                            <Vertex pos="-2.625 -0.25 0.125" />
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.875 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 0 1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 6208 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3776 0 1 0 2432 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-41.1213 -35.25 18.0555" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -41.1213 0 1 0 -35.25 -0.707107 0 0.707107 18.0555 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.375" />
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.375" />
                            <Vertex pos="-0.125 0.25 2.625" />
                            <Vertex pos="-0.125 -0.25 2.625" />
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.875" />
                        </Vertices>
                        <Face id="0" plane="-0 -0.707107 -0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 1920 1 0 0 -960 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-37.0555 -35.25 22.1213" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -37.0555 0 1 0 -35.25 -0.707107 0 0.707107 22.1213 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.375" />
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.375" />
                            <Vertex pos="-0.125 0.25 -2.625" />
                            <Vertex pos="-0.125 -0.25 -2.625" />
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.875" />
                        </Vertices>
                        <Face id="0" plane="0 -0.707107 0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 192 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 64 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="1 -0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0.707107 -0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 1920 1 0 0 -960 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="-40.9445 -35.25 17.8787" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -40.9445 0 1 0 -35.25 -0.707107 0 0.707107 17.8787 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 -2.875" />
                            <Vertex pos="0.125 -0.25 -2.375" />
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.375" />
                            <Vertex pos="0.125 0.25 2.625" />
                            <Vertex pos="0.125 -0.25 2.625" />
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.875" />
                        </Vertices>
                        <Face id="0" plane="-0 -0.707107 -0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 0 -1 -1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 1216 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 128 1 0 0 -832 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-36.8787 -35.25 21.9445" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -36.8787 0 1 0 -35.25 -0.707107 0 0.707107 21.9445 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.125 0.25 2.875" />
                            <Vertex pos="0.125 -0.25 2.375" />
                            <Vertex pos="-0.125 0.25 2.875" />
                            <Vertex pos="-0.125 -0.25 2.375" />
                            <Vertex pos="0.125 0.25 -2.625" />
                            <Vertex pos="0.125 -0.25 -2.625" />
                            <Vertex pos="-0.125 0.25 -2.875" />
                            <Vertex pos="-0.125 -0.25 -2.875" />
                        </Vertices>
                        <Face id="0" plane="0 -0.707107 0.707107 -1.85616" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="1 -0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 1 0 128 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="-1 0 0 64 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="1 0 0 192 0 0 -1 -4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-1 0 0 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 -1664 0 0 1 4160 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 1 0 128 1 0 0 -832 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="-41.1213 -35.25 21.9445" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -41.1213 0 1 0 -35.25 -0.707107 0 0.707107 21.9445 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.375 -0.25 -0.125" />
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.375 -0.25 0.125" />
                            <Vertex pos="2.625 0.25 -0.125" />
                            <Vertex pos="2.625 -0.25 -0.125" />
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.875 -0.25 0.125" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 192 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0 -1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 -0 1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 3264 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3648 0 1 0 1920 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="-37.0555 -35.25 17.8787" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -37.0555 0 1 0 -35.25 -0.707107 0 0.707107 17.8787 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.375 -0.25 -0.125" />
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.375 -0.25 0.125" />
                            <Vertex pos="-2.625 0.25 -0.125" />
                            <Vertex pos="-2.625 -0.25 -0.125" />
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.875 -0.25 0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 192 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 0 -1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 192 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0 0 1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 6208 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 -0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3648 0 1 0 1920 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="-40.9445 -35.25 22.1213" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -40.9445 0 1 0 -35.25 -0.707107 0 0.707107 22.1213 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.875 0.25 0.125" />
                            <Vertex pos="-2.375 -0.25 0.125" />
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.375 -0.25 -0.125" />
                            <Vertex pos="2.625 0.25 0.125" />
                            <Vertex pos="2.625 -0.25 0.125" />
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.875 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 64 0 1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0 1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 1 0 0 1472 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -1 0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 -1 0 0 1088 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="-0 -0 -1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 3264 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0.707107 -0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3776 0 1 0 2432 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="-36.8787 -35.25 18.0555" rot="0 -1 0 0.785398" scale="" transform="0.707107 0 0.707107 -36.8787 0 1 0 -35.25 -0.707107 0 0.707107 18.0555 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.875 0.25 0.125" />
                            <Vertex pos="2.375 -0.25 0.125" />
                            <Vertex pos="2.875 0.25 -0.125" />
                            <Vertex pos="2.375 -0.25 -0.125" />
                            <Vertex pos="-2.625 0.25 0.125" />
                            <Vertex pos="-2.625 -0.25 0.125" />
                            <Vertex pos="-2.875 0.25 -0.125" />
                            <Vertex pos="-2.875 -0.25 -0.125" />
                        </Vertices>
                        <Face id="0" plane="0.707107 -0.707107 0 -1.85616" album="Blasted" material="bm_beam" texgens="0 0 -1 64 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 0 1 -0.125" album="Blasted" material="bm_beam" texgens="0 -1 0 128 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 1 0 0 4416 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -1 -0 -0.25" album="Blasted" material="bm_beam" texgens="0 0 -1 64 -1 0 0 -1856 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0 -1 -0.125" album="Blasted" material="bm_beam" texgens="1 0 0 6208 0 -1 0 128 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="-0.707107 0 0.707107 -1.94454" album="Blasted" material="bm_beam" texgens="0 0 1 3776 0 1 0 2432 0 0.0625 0.0625" texRot="0" texScale="0.0625 0.0625" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
