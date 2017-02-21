// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:32743,y:32804,varname:node_4013,prsc:2|emission-6622-OUT;n:type:ShaderForge.SFN_Tex2d,id:3863,x:31482,y:33092,ptovrint:False,ptlb:Noise,ptin:_Noise,varname:node_3863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Add,id:1638,x:31672,y:32897,varname:node_1638,prsc:2|A-9398-OUT,B-3863-R;n:type:ShaderForge.SFN_RemapRange,id:9398,x:31482,y:32897,varname:node_9398,prsc:2,frmn:0,frmx:1,tomn:-0.8,tomx:0.8|IN-5996-OUT;n:type:ShaderForge.SFN_OneMinus,id:5996,x:31324,y:32897,varname:node_5996,prsc:2|IN-5120-OUT;n:type:ShaderForge.SFN_RemapRange,id:7214,x:31846,y:32897,varname:node_7214,prsc:2,frmn:0,frmx:1,tomn:-4,tomx:4|IN-1638-OUT;n:type:ShaderForge.SFN_Clamp01,id:536,x:32017,y:32897,varname:node_536,prsc:2|IN-7214-OUT;n:type:ShaderForge.SFN_OneMinus,id:2236,x:32174,y:32897,varname:node_2236,prsc:2|IN-536-OUT;n:type:ShaderForge.SFN_Time,id:7045,x:30842,y:32791,varname:node_7045,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6992,x:31002,y:32897,varname:node_6992,prsc:2|A-7045-T,B-4773-OUT,C-7152-OUT;n:type:ShaderForge.SFN_Color,id:7899,x:32117,y:33036,ptovrint:False,ptlb:PrimaryColour,ptin:_PrimaryColour,varname:node_7899,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.965213,c2:1,c3:0.6397059,c4:1;n:type:ShaderForge.SFN_Tau,id:4773,x:30842,y:32915,varname:node_4773,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7152,x:30842,y:33047,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_7152,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Color,id:3852,x:32017,y:32742,ptovrint:False,ptlb:SecondaryColour,ptin:_SecondaryColour,varname:node_3852,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1172414,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Add,id:6622,x:32519,y:32897,varname:node_6622,prsc:2|A-5371-OUT,B-3814-OUT;n:type:ShaderForge.SFN_Multiply,id:5371,x:32348,y:32897,varname:node_5371,prsc:2|A-2236-OUT,B-3852-RGB;n:type:ShaderForge.SFN_Multiply,id:3814,x:32348,y:33046,varname:node_3814,prsc:2|A-7899-RGB,B-536-OUT;n:type:ShaderForge.SFN_Frac,id:5120,x:31158,y:32988,varname:node_5120,prsc:2|IN-6992-OUT;proporder:3863-7899-7152-3852;pass:END;sub:END;*/

Shader "Shader Forge/Practice7" {
    Properties {
        _Noise ("Noise", 2D) = "white" {}
        _PrimaryColour ("PrimaryColour", Color) = (0.965213,1,0.6397059,1)
        _Speed ("Speed", Float ) = 0.2
        _SecondaryColour ("SecondaryColour", Color) = (0.1172414,1,0,1)
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
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _Noise; uniform float4 _Noise_ST;
            uniform float4 _PrimaryColour;
            uniform float _Speed;
            uniform float4 _SecondaryColour;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_7045 = _Time + _TimeEditor;
                float4 _Noise_var = tex2D(_Noise,TRANSFORM_TEX(i.uv0, _Noise));
                float node_536 = saturate(((((1.0 - frac((node_7045.g*6.28318530718*_Speed)))*1.6+-0.8)+_Noise_var.r)*8.0+-4.0));
                float3 emissive = (((1.0 - node_536)*_SecondaryColour.rgb)+(_PrimaryColour.rgb*node_536));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
