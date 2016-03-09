//Maya ASCII 2016 scene
//Name: warningStripMesh.ma
//Last modified: Wed, Mar 09, 2016 02:12:30 PM
//Codeset: UTF-8
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Mac OS X 10.9.5";
fileInfo "license" "student";
createNode transform -n "pCube4";
	rename -uid "CD073B71-BA48-A332-5C31-56BCA2E2B935";
	setAttr ".t" -type "double3" 5.5385273234177337 0 1.0249428079138756 ;
	setAttr ".s" -type "double3" 1 9.9999999999999998e-13 1 ;
createNode mesh -n "pCubeShape3" -p "pCube4";
	rename -uid "66C0CDFF-794E-F686-43A5-7A8BDF3A9054";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bck" 3;
createNode transform -n "pCube5";
	rename -uid "6B0D41E2-B041-DE9C-9C74-EDB1FA56F497";
	setAttr ".t" -type "double3" 0.86394611364512786 0 -9.5706925445763318 ;
	setAttr ".s" -type "double3" 1 9.9999999999999998e-13 1 ;
createNode mesh -n "pCubeShape4" -p "pCube5";
	rename -uid "A415C783-2045-ED50-3090-0F816E06B30F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bck" 3;
createNode transform -n "pCube6";
	rename -uid "12523C96-8A44-5E04-E6D3-7DB6ED23038B";
	setAttr ".t" -type "double3" -3.838217750580684 0 1.0249428079138756 ;
	setAttr ".s" -type "double3" 1 9.9999999999999998e-13 1 ;
createNode mesh -n "pCubeShape6" -p "pCube6";
	rename -uid "FB11E87D-944D-0962-02FF-E089146B39F3";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -0.43173558 -0.5 10.95510101 0.43173558 -0.5 10.95510101
		 -0.43173558 0.5 10.95510101 0.43173558 0.5 10.95510101 -0.43173558 0.5 -10.95510101
		 0.43173558 0.5 -10.95510101 -0.43173558 -0.5 -10.95510101 0.43173558 -0.5 -10.95510101;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube7";
	rename -uid "50A11696-5B40-D4D6-EF61-3CB013DE1C97";
	setAttr ".t" -type "double3" 0.86394611364512786 0 11.694970712285851 ;
	setAttr ".s" -type "double3" 1 9.9999999999999998e-13 1 ;
createNode mesh -n "pCubeShape7" -p "pCube7";
	rename -uid "9D75C1A9-4E41-8698-884D-59878FDA114F";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -4.30521202 -0.5 0.44706029 4.30521202 -0.5 0.44706029
		 -4.30521202 0.5 0.44706029 4.30521202 0.5 0.44706029 -4.30521202 0.5 -0.44706029
		 4.30521202 0.5 -0.44706029 -4.30521202 -0.5 -0.44706029 4.30521202 -0.5 -0.44706029;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode polyCube -n "polyCube3";
	rename -uid "0368D88C-DF4A-5DEC-88A0-2CB2D5AFF54B";
	setAttr ".w" 0.8634711777056685;
	setAttr ".d" 21.910202326622503;
	setAttr ".cuv" 4;
createNode polyCube -n "polyCube4";
	rename -uid "F0E657E5-F74D-BB46-C3B9-E1B8E3767A20";
	setAttr ".w" 8.6104244594147552;
	setAttr ".d" 0.89412055729943596;
	setAttr ".cuv" 4;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 9 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 5 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "polyCube3.out" "pCubeShape3.i";
connectAttr "polyCube4.out" "pCubeShape4.i";
connectAttr "pCubeShape3.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape4.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape6.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape7.iog" ":initialShadingGroup.dsm" -na;
// End of warningStripMesh.ma
