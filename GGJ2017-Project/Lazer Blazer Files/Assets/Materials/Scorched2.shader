// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:33454,y:32710,varname:node_4013,prsc:2|diff-318-OUT,spec-7058-OUT,normal-5101-RGB,emission-763-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:2966,x:32653,y:33133,ptovrint:False,ptlb:Burn Texture,ptin:_BurnTexture,varname:node_2966,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:1498,x:32796,y:33034,varname:node_1498,prsc:2,tex:271f5ee3273dd7f4fae6e204d4f8c4bf,ntxv:0,isnm:False|UVIN-7469-OUT,TEX-2966-TEX;n:type:ShaderForge.SFN_Append,id:7469,x:32653,y:32929,varname:node_7469,prsc:2|A-5063-OUT,B-2064-OUT;n:type:ShaderForge.SFN_Vector1,id:2064,x:32653,y:32882,varname:node_2064,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:8204,x:30883,y:32868,ptovrint:False,ptlb:Dissolve Amount,ptin:_DissolveAmount,varname:node_8204,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3377738,max:1;n:type:ShaderForge.SFN_Add,id:1638,x:31680,y:32949,varname:node_1638,prsc:2|A-9398-OUT,B-9179-OUT;n:type:ShaderForge.SFN_RemapRange,id:9398,x:31478,y:32879,varname:node_9398,prsc:2,frmn:0,frmx:1,tomn:-0.8,tomx:0.8|IN-5996-OUT;n:type:ShaderForge.SFN_OneMinus,id:5996,x:31320,y:32879,varname:node_5996,prsc:2|IN-8204-OUT;n:type:ShaderForge.SFN_RemapRange,id:7214,x:31857,y:32963,varname:node_7214,prsc:2,frmn:0,frmx:1,tomn:-4,tomx:4|IN-1638-OUT;n:type:ShaderForge.SFN_Clamp01,id:536,x:32036,y:32946,varname:node_536,prsc:2|IN-7214-OUT;n:type:ShaderForge.SFN_Tex2d,id:4786,x:31806,y:32479,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_4786,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3243824e0304c8441812239874a85a33,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5101,x:32653,y:32722,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_5101,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3243824e0304c8441812239874a85a33,ntxv:3,isnm:False;n:type:ShaderForge.SFN_Vector1,id:7058,x:32926,y:32684,varname:node_7058,prsc:2,v1:0;n:type:ShaderForge.SFN_Noise,id:7893,x:31187,y:33253,varname:node_7893,prsc:2|XY-5585-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:5585,x:30875,y:33214,varname:node_5585,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:9179,x:31424,y:33105,varname:node_9179,prsc:2|A-6525-OUT,B-9705-OUT;n:type:ShaderForge.SFN_Multiply,id:9705,x:31408,y:33295,varname:node_9705,prsc:2|A-290-R,B-7893-OUT,C-1150-OUT;n:type:ShaderForge.SFN_Vector1,id:1150,x:31187,y:33372,varname:node_1150,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Tex2d,id:290,x:31150,y:33027,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_290,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:7819,x:32055,y:32832,ptovrint:False,ptlb:Scorched,ptin:_Scorched,varname:node_7819,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4926471,c2:0.4926471,c3:0.4926471,c4:1;n:type:ShaderForge.SFN_OneMinus,id:5063,x:32240,y:32872,varname:node_5063,prsc:2|IN-536-OUT;n:type:ShaderForge.SFN_Multiply,id:1787,x:33014,y:33034,varname:node_1787,prsc:2|A-318-OUT,B-1498-RGB;n:type:ShaderForge.SFN_Multiply,id:6531,x:32304,y:32497,varname:node_6531,prsc:2|A-4786-RGB,B-536-OUT,C-4627-RGB;n:type:ShaderForge.SFN_Multiply,id:2887,x:32304,y:32654,varname:node_2887,prsc:2|A-4786-RGB,B-5063-OUT,C-7819-RGB;n:type:ShaderForge.SFN_Add,id:318,x:32602,y:32526,varname:node_318,prsc:2|A-6531-OUT,B-2887-OUT,C-4951-RGB;n:type:ShaderForge.SFN_Color,id:4627,x:31830,y:32689,ptovrint:False,ptlb:Tint,ptin:_Tint,varname:node_4627,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9448276,c2:0,c3:1,c4:1;n:type:ShaderForge.SFN_Ceil,id:6483,x:32287,y:33051,varname:node_6483,prsc:2|IN-5063-OUT;n:type:ShaderForge.SFN_Floor,id:2948,x:32287,y:33179,varname:node_2948,prsc:2|IN-5063-OUT;n:type:ShaderForge.SFN_Subtract,id:4891,x:32465,y:33288,varname:node_4891,prsc:2|A-6483-OUT,B-2948-OUT;n:type:ShaderForge.SFN_Add,id:763,x:33102,y:33188,varname:node_763,prsc:2|A-1787-OUT,B-3337-OUT,C-4951-RGB;n:type:ShaderForge.SFN_Multiply,id:3337,x:32744,y:33396,varname:node_3337,prsc:2|A-4891-OUT,B-9329-OUT;n:type:ShaderForge.SFN_Slider,id:9329,x:32344,y:33478,ptovrint:False,ptlb:Glow,ptin:_Glow,varname:node_9329,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Color,id:4951,x:33155,y:32833,ptovrint:False,ptlb:Highlighted,ptin:_Highlighted,varname:node_4951,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Tex2d,id:3543,x:30875,y:33446,ptovrint:False,ptlb:Wave,ptin:_Wave,varname:node_3543,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3a5a96df060a5cf4a9cc0c59e13486b7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_OneMinus,id:6525,x:31092,y:33547,varname:node_6525,prsc:2|IN-3543-RGB;proporder:2966-8204-4786-5101-290-7819-4627-9329-4951-3543;pass:END;sub:END;*/

Shader "Shader Forge/Scorched2" {
    Properties {
        _BurnTexture ("Burn Texture", 2D) = "white" {}
        _DissolveAmount ("Dissolve Amount", Range(0, 1)) = 0.3377738
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Normal ("Normal", 2D) = "bump" {}
        _Noise ("Noise", 2D) = "white" {}
        _Scorched ("Scorched", Color) = (0.4926471,0.4926471,0.4926471,1)
        _Tint ("Tint", Color) = (0.9448276,0,1,1)
        _Glow ("Glow", Range(0, 1)) = 1
        _Highlighted ("Highlighted", Color) = (0,0,0,1)
        _Wave ("Wave", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _BurnTexture; uniform float4 _BurnTexture_ST;
            uniform float _DissolveAmount;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float4 _Scorched;
            uniform float4 _Tint;
            uniform float _Glow;
            uniform float4 _Highlighted;
            uniform sampler2D _Wave; uniform float4 _Wave_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _Normal_var = tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float4 _Wave_var = tex2D(_Wave,TRANSFORM_TEX(i.uv0, _Wave));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float2 node_7893_skew = i.uv0 + 0.2127+i.uv0.x*0.3713*i.uv0.y;
                float2 node_7893_rnd = 4.789*sin(489.123*(node_7893_skew));
                float node_7893 = frac(node_7893_rnd.x*node_7893_rnd.y*(1+node_7893_skew.x));
                float3 node_536 = saturate(((((1.0 - _DissolveAmount)*1.6+-0.8)+((1.0 - _Wave_var.rgb)+(_Noise_var.r*node_7893*0.2)))*8.0+-4.0));
                float3 node_5063 = (1.0 - node_536);
                float3 node_318 = ((_Diffuse_var.rgb*node_536*_Tint.rgb)+(_Diffuse_var.rgb*node_5063*_Scorched.rgb)+_Highlighted.rgb);
                float3 diffuseColor = node_318; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz)*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 node_7469 = float4(node_5063,0.0);
                float4 node_1498 = tex2D(_BurnTexture,TRANSFORM_TEX(node_7469, _BurnTexture));
                float3 emissive = ((node_318*node_1498.rgb)+((ceil(node_5063)-floor(node_5063))*_Glow)+_Highlighted.rgb);
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _BurnTexture; uniform float4 _BurnTexture_ST;
            uniform float _DissolveAmount;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float4 _Scorched;
            uniform float4 _Tint;
            uniform float _Glow;
            uniform float4 _Highlighted;
            uniform sampler2D _Wave; uniform float4 _Wave_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 _Normal_var = tex2D(_Normal,TRANSFORM_TEX(i.uv0, _Normal));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 0.5;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float4 _Wave_var = tex2D(_Wave,TRANSFORM_TEX(i.uv0, _Wave));
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float2 node_7893_skew = i.uv0 + 0.2127+i.uv0.x*0.3713*i.uv0.y;
                float2 node_7893_rnd = 4.789*sin(489.123*(node_7893_skew));
                float node_7893 = frac(node_7893_rnd.x*node_7893_rnd.y*(1+node_7893_skew.x));
                float3 node_536 = saturate(((((1.0 - _DissolveAmount)*1.6+-0.8)+((1.0 - _Wave_var.rgb)+(_Noise_var.r*node_7893*0.2)))*8.0+-4.0));
                float3 node_5063 = (1.0 - node_536);
                float3 node_318 = ((_Diffuse_var.rgb*node_536*_Tint.rgb)+(_Diffuse_var.rgb*node_5063*_Scorched.rgb)+_Highlighted.rgb);
                float3 diffuseColor = node_318; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, GGXTerm(NdotH, 1.0-gloss));
                float specularPBL = (NdotL*visTerm*normTerm) * (UNITY_PI / 4);
                if (IsGammaSpace())
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                specularPBL = max(0, specularPBL * NdotL);
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
