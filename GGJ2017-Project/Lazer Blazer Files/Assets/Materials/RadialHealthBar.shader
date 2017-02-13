// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:32688,y:32340,varname:node_4013,prsc:2|diff-3276-OUT,emission-3276-OUT,clip-1493-OUT;n:type:ShaderForge.SFN_TexCoord,id:4923,x:30939,y:32643,varname:node_4923,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:509,x:31112,y:32488,ptovrint:False,ptlb:heath,ptin:_heath,varname:node_509,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.0940171,max:1;n:type:ShaderForge.SFN_RemapRange,id:3757,x:31141,y:32643,varname:node_3757,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-4923-UVOUT;n:type:ShaderForge.SFN_Length,id:6975,x:31360,y:32914,varname:node_6975,prsc:2|IN-3757-OUT;n:type:ShaderForge.SFN_Floor,id:6483,x:31854,y:32969,varname:node_6483,prsc:2|IN-6975-OUT;n:type:ShaderForge.SFN_OneMinus,id:9842,x:32017,y:32969,varname:node_9842,prsc:2|IN-6483-OUT;n:type:ShaderForge.SFN_Add,id:8874,x:31854,y:32820,varname:node_8874,prsc:2|A-9829-OUT,B-6975-OUT;n:type:ShaderForge.SFN_Vector1,id:9829,x:31564,y:32823,varname:node_9829,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Floor,id:1143,x:32017,y:32820,varname:node_1143,prsc:2|IN-8874-OUT;n:type:ShaderForge.SFN_Multiply,id:1493,x:32456,y:32619,varname:node_1493,prsc:2|A-7947-OUT,B-1143-OUT,C-9842-OUT;n:type:ShaderForge.SFN_ArcTan2,id:8665,x:31673,y:32665,varname:node_8665,prsc:2,attp:2|A-8360-G,B-8360-R;n:type:ShaderForge.SFN_ComponentMask,id:8360,x:31355,y:32643,varname:node_8360,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-3757-OUT;n:type:ShaderForge.SFN_Ceil,id:7127,x:32066,y:32619,varname:node_7127,prsc:2|IN-44-OUT;n:type:ShaderForge.SFN_OneMinus,id:7947,x:32258,y:32619,varname:node_7947,prsc:2|IN-7127-OUT;n:type:ShaderForge.SFN_Subtract,id:44,x:31898,y:32619,varname:node_44,prsc:2|A-509-OUT,B-8665-OUT;n:type:ShaderForge.SFN_Lerp,id:2118,x:32013,y:32025,varname:node_2118,prsc:2|A-3700-RGB,B-5878-RGB,T-509-OUT;n:type:ShaderForge.SFN_Color,id:5878,x:31749,y:32153,ptovrint:False,ptlb:node_5878,ptin:_node_5878,varname:node_5878,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7843137,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:3700,x:31749,y:31941,ptovrint:False,ptlb:node_3700,ptin:_node_3700,varname:node_3700,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Lerp,id:3276,x:32180,y:32209,varname:node_3276,prsc:2|A-2118-OUT,B-6653-RGB,T-509-OUT;n:type:ShaderForge.SFN_Color,id:6653,x:31957,y:32356,ptovrint:False,ptlb:node_5878_copy,ptin:_node_5878_copy,varname:_node_5878_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;proporder:509-5878-3700-6653;pass:END;sub:END;*/

Shader "Shader Forge/practice4" {
    Properties {
        _heath ("heath", Range(0, 1)) = 0.0940171
        _node_5878 ("node_5878", Color) = (0.7843137,1,0,1)
        _node_3700 ("node_3700", Color) = (0,1,0,1)
        _node_5878_copy ("node_5878_copy", Color) = (1,0,0,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _heath;
            uniform float4 _node_5878;
            uniform float4 _node_3700;
            uniform float4 _node_5878_copy;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float2 node_3757 = (i.uv0*2.0+-1.0);
                float2 node_8360 = node_3757.rg;
                float node_6975 = length(node_3757);
                clip(((1.0 - ceil((_heath-((atan2(node_8360.g,node_8360.r)/6.28318530718)+0.5))))*floor((0.3+node_6975))*(1.0 - floor(node_6975))) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 node_3276 = lerp(lerp(_node_3700.rgb,_node_5878.rgb,_heath),_node_5878_copy.rgb,_heath);
                float3 diffuseColor = node_3276;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = node_3276;
/// Final Color:
                float3 finalColor = diffuse + emissive;
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
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _heath;
            uniform float4 _node_5878;
            uniform float4 _node_3700;
            uniform float4 _node_5878_copy;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float2 node_3757 = (i.uv0*2.0+-1.0);
                float2 node_8360 = node_3757.rg;
                float node_6975 = length(node_3757);
                clip(((1.0 - ceil((_heath-((atan2(node_8360.g,node_8360.r)/6.28318530718)+0.5))))*floor((0.3+node_6975))*(1.0 - floor(node_6975))) - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 node_3276 = lerp(lerp(_node_3700.rgb,_node_5878.rgb,_heath),_node_5878_copy.rgb,_heath);
                float3 diffuseColor = node_3276;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float _heath;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 node_3757 = (i.uv0*2.0+-1.0);
                float2 node_8360 = node_3757.rg;
                float node_6975 = length(node_3757);
                clip(((1.0 - ceil((_heath-((atan2(node_8360.g,node_8360.r)/6.28318530718)+0.5))))*floor((0.3+node_6975))*(1.0 - floor(node_6975))) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
