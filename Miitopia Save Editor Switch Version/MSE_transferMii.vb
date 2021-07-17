Imports System
Imports PackageIO
Imports System.IO
Public Class MSE_transferMii
    Private IsFormBeingDragged As Boolean = False
    Private MousedwnX As Integer
    Private MousedwnY As Integer
    Dim applicationpath = Application.StartupPath
    Dim mainsav = MSE_hub.Text_filepath.Text
    Dim Miiappareance As String
    Dim Mii_common_1 = &H2FC8 '&h800 x ? (Mii appareance, make up,...)
    Dim Mii_hero_1 = &HFCFD8 '&h340 x 10 (Mii equipment,jobs,...)
    Dim Mii_name_1 = &H2FE8
    Dim Mii_name_2 = &H37E8
    Dim Mii_name_3 = &H3FE8
    Dim Mii_name_4 = &H47E8
    Dim Mii_name_5 = &H4FE8
    Dim Mii_name_6 = &H57E8
    Dim Mii_name_7 = &H5FE8
    Dim Mii_name_8 = &H67E8
    Dim Mii_name_9 = &H6FE8
    Dim Mii_name_10 = &H77E8
    Dim Mii_name_11 = &H7FE8
    Dim Mii_name_12 = &H87E8
    Dim Mii_name_13 = &H8FE8
    Dim Mii_name_14 = &H97E8
    Dim Mii_name_15 = &H9FE8
    Dim Mii_name_16 = &HA7E8
    Dim Mii_name_17 = &HAFE8
    Dim Mii_name_18 = &HB7E8
    Dim Mii_name_19 = &HBFE8
    Dim Mii_name_20 = &HC7E8
    Dim Mii_name_21 = &HCFE8
    Dim Mii_name_22 = &HD7E8
    Dim Mii_name_23 = &HDFE8
    Dim Mii_name_24 = &HE7E8
    Dim Mii_name_25 = &HEFE8
    Dim Mii_name_26 = &HF7E8
    Dim Mii_name_27 = &HFFE8
    Dim Mii_name_28 = &H107E8
    Dim Mii_name_29 = &H10FE8
    Dim Mii_name_30 = &H117E8
    Dim Mii_name_31 = &H11FE8
    Dim Mii_name_32 = &H127E8
    Dim Mii_name_33 = &H12FE8
    Dim Mii_name_34 = &H137E8
    Dim Mii_name_35 = &H13FE8
    Dim Mii_name_36 = &H147E8
    Dim Mii_name_37 = &H14FE8
    Dim Mii_name_38 = &H157E8
    Dim Mii_name_39 = &H15FE8
    Dim Mii_name_40 = &H167E8
    Dim Mii_name_41 = &H16FE8
    Dim Mii_name_42 = &H177E8
    Dim Mii_name_43 = &H17FE8
    Dim Mii_name_44 = &H187E8
    Dim Mii_name_45 = &H18FE8
    Dim Mii_name_46 = &H197E8
    Dim Mii_name_47 = &H19FE8
    Dim Mii_name_48 = &H1A7E8
    Dim Mii_name_49 = &H1AFE8
    Dim Mii_name_50 = &H1B7E8
    Dim Mii_name_51 = &H1BFE8
    Dim Mii_name_52 = &H1C7E8
    Dim Mii_name_53 = &H1CFE8
    Dim Mii_name_54 = &H1D7E8
    Dim Mii_name_55 = &H1DFE8
    Dim Mii_name_56 = &H1E7E8
    Dim Mii_name_57 = &H1EFE8
    Dim Mii_name_58 = &H1F7E8
    Dim Mii_name_59 = &H1FFE8
    Dim Mii_name_60 = &H207E8
    Dim Mii_name_61 = &H20FE8
    Dim Mii_name_62 = &H217E8
    Dim Mii_name_63 = &H21FE8
    Dim Mii_name_64 = &H227E8
    Dim Mii_name_65 = &H22FE8
    Dim Mii_name_66 = &H237E8
    Dim Mii_name_67 = &H23FE8
    Dim Mii_name_68 = &H247E8
    Dim Mii_name_69 = &H24FE8
    Dim Mii_name_70 = &H257E8
    Dim Mii_name_71 = &H25FE8
    Dim Mii_name_72 = &H267E8
    Dim Mii_name_73 = &H26FE8
    Dim Mii_name_74 = &H277E8
    Dim Mii_name_75 = &H27FE8
    Dim Mii_name_76 = &H287E8
    Dim Mii_name_77 = &H28FE8
    Dim Mii_name_78 = &H297E8
    Dim Mii_name_79 = &H29FE8
    Dim Mii_name_80 = &H2A7E8
    Dim Mii_name_81 = &H2AFE8
    Dim Mii_name_82 = &H2B7E8
    Dim Mii_name_83 = &H2BFE8
    Dim Mii_name_84 = &H2C7E8
    Dim Mii_name_85 = &H2CFE8
    Dim Mii_name_86 = &H2D7E8
    Dim Mii_name_87 = &H2DFE8
    Dim Mii_name_88 = &H2E7E8
    Dim Mii_name_89 = &H2EFE8
    Dim Mii_name_90 = &H2F7E8
    Dim Mii_name_91 = &H2FFE8
    Dim Mii_name_92 = &H307E8
    Dim Mii_name_93 = &H30FE8
    Dim Mii_name_94 = &H317E8
    Dim Mii_name_95 = &H31FE8
    Dim Mii_name_96 = &H327E8
    Dim Mii_name_97 = &H32FE8
    Dim Mii_name_98 = &H337E8
    Dim Mii_name_99 = &H33FE8
    Dim Mii_name_100 = &H347E8
    Dim Mii_name_101 = &H34FE8
    Dim Mii_name_102 = &H357E8
    Dim Mii_name_103 = &H35FE8
    Dim Mii_name_104 = &H367E8
    Dim Mii_name_105 = &H36FE8
    Dim Mii_name_106 = &H377E8
    Dim Mii_name_107 = &H37FE8
    Dim Mii_name_108 = &H387E8
    Dim Mii_name_109 = &H38FE8
    Dim Mii_name_110 = &H397E8
    Dim Mii_name_111 = &H39FE8
    Dim Mii_name_112 = &H3A7E8
    Dim Mii_name_113 = &H3AFE8
    Dim Mii_name_114 = &H3B7E8
    Dim Mii_name_115 = &H3BFE8
    Dim Mii_name_116 = &H3C7E8
    Dim Mii_name_117 = &H3CFE8
    Dim Mii_name_118 = &H3D7E8
    Dim Mii_name_119 = &H3DFE8
    Dim Mii_name_120 = &H3E7E8
    Dim Mii_name_121 = &H3EFE8
    Dim Mii_name_122 = &H3F7E8
    Dim Mii_name_123 = &H3FFE8
    Dim Mii_name_124 = &H407E8
    Dim Mii_name_125 = &H40FE8
    Dim Mii_name_126 = &H417E8
    Dim Mii_name_127 = &H41FE8
    Dim Mii_name_128 = &H427E8
    Dim Mii_name_129 = &H42FE8
    Dim Mii_name_130 = &H437E8
    Dim Mii_name_131 = &H43FE8
    Dim Mii_name_132 = &H447E8
    Dim Mii_name_133 = &H44FE8
    Dim Mii_name_134 = &H457E8
    Dim Mii_name_135 = &H45FE8
    Dim Mii_name_136 = &H467E8
    Dim Mii_name_137 = &H46FE8
    Dim Mii_name_138 = &H477E8
    Dim Mii_name_139 = &H47FE8
    Dim Mii_name_140 = &H487E8
    Dim Mii_name_141 = &H48FE8
    Dim Mii_name_142 = &H497E8
    Dim Mii_name_143 = &H49FE8
    Dim Mii_name_144 = &H4A7E8
    Dim Mii_name_145 = &H4AFE8
    Dim Mii_name_146 = &H4B7E8
    Dim Mii_name_147 = &H4BFE8
    Dim Mii_name_148 = &H4C7E8
    Dim Mii_name_149 = &H4CFE8
    Dim Mii_name_150 = &H4D7E8
    Dim Mii_name_151 = &H4DFE8
    Dim Mii_name_152 = &H4E7E8
    Dim Mii_name_153 = &H4EFE8
    Dim Mii_name_154 = &H4F7E8
    Dim Mii_name_155 = &H4FFE8
    Dim Mii_name_156 = &H507E8
    Dim Mii_name_157 = &H50FE8
    Dim Mii_name_158 = &H517E8
    Dim Mii_name_159 = &H51FE8
    Dim Mii_name_160 = &H527E8
    Dim Mii_name_161 = &H52FE8
    Dim Mii_name_162 = &H537E8
    Dim Mii_name_163 = &H53FE8
    Dim Mii_name_164 = &H547E8
    Dim Mii_name_165 = &H54FE8
    Dim Mii_name_166 = &H557E8
    Dim Mii_name_167 = &H55FE8
    Dim Mii_name_168 = &H567E8
    Dim Mii_name_169 = &H56FE8
    Dim Mii_name_170 = &H577E8
    Dim Mii_name_171 = &H57FE8
    Dim Mii_name_172 = &H587E8
    Dim Mii_name_173 = &H58FE8
    Dim Mii_name_174 = &H597E8
    Dim Mii_name_175 = &H59FE8
    Dim Mii_name_176 = &H5A7E8
    Dim Mii_name_177 = &H5AFE8
    Dim Mii_name_178 = &H5B7E8
    Dim Mii_name_179 = &H5BFE8
    Dim Mii_name_180 = &H5C7E8
    Dim Mii_name_181 = &H5CFE8
    Dim Mii_name_182 = &H5D7E8
    Dim Mii_name_183 = &H5DFE8
    Dim Mii_name_184 = &H5E7E8
    Dim Mii_name_185 = &H5EFE8
    Dim Mii_name_186 = &H5F7E8
    Dim Mii_name_187 = &H5FFE8
    Dim Mii_name_188 = &H607E8
    Dim Mii_name_189 = &H60FE8
    Dim Mii_name_190 = &H617E8
    Dim Mii_name_191 = &H61FE8
    Dim Mii_name_192 = &H627E8
    Dim Mii_name_193 = &H62FE8
    Dim Mii_name_194 = &H637E8
    Dim Mii_name_195 = &H63FE8
    Dim Mii_name_196 = &H647E8
    Dim Mii_name_197 = &H64FE8
    Dim Mii_name_198 = &H657E8
    Dim Mii_name_199 = &H65FE8
    Dim Mii_name_200 = &H667E8
    Dim Mii_name_201 = &H66FE8
    Dim Mii_name_202 = &H677E8
    Dim Mii_name_203 = &H67FE8
    Dim Mii_name_204 = &H687E8
    Dim Mii_name_205 = &H68FE8
    Dim Mii_name_206 = &H697E8
    Dim Mii_name_207 = &H69FE8
    Dim Mii_name_208 = &H6A7E8
    Dim Mii_name_209 = &H6AFE8
    Dim Mii_name_210 = &H6B7E8
    Dim Mii_name_211 = &H6BFE8
    Dim Mii_name_212 = &H6C7E8
    Dim Mii_name_213 = &H6CFE8
    Dim Mii_name_214 = &H6D7E8
    Dim Mii_name_215 = &H6DFE8
    Dim Mii_name_216 = &H6E7E8
    Dim Mii_name_217 = &H6EFE8
    Dim Mii_name_218 = &H6F7E8
    Dim Mii_name_219 = &H6FFE8
    Dim Mii_name_220 = &H707E8
    Dim Mii_name_221 = &H70FE8
    Dim Mii_name_222 = &H717E8
    Dim Mii_name_223 = &H71FE8
    Dim Mii_name_224 = &H727E8
    Dim Mii_name_225 = &H72FE8
    Dim Mii_name_226 = &H737E8
    Dim Mii_name_227 = &H73FE8
    Dim Mii_name_228 = &H747E8
    Dim Mii_name_229 = &H74FE8
    Dim Mii_name_230 = &H757E8
    Dim Mii_name_231 = &H75FE8
    Dim Mii_name_232 = &H767E8
    Dim Mii_name_233 = &H76FE8
    Dim Mii_name_234 = &H777E8
    Dim Mii_name_235 = &H77FE8
    Dim Mii_name_236 = &H787E8
    Dim Mii_name_237 = &H78FE8
    Dim Mii_name_238 = &H797E8
    Dim Mii_name_239 = &H79FE8
    Dim Mii_name_240 = &H7A7E8
    Dim Mii_name_241 = &H7AFE8
    Dim Mii_name_242 = &H7B7E8
    Dim Mii_name_243 = &H7BFE8
    Dim Mii_name_244 = &H7C7E8
    Dim Mii_name_245 = &H7CFE8
    Dim Mii_name_246 = &H7D7E8
    Dim Mii_name_247 = &H7DFE8
    Dim Mii_name_248 = &H7E7E8
    Dim Mii_name_249 = &H7EFE8
    Dim Mii_name_250 = &H7F7E8
    Dim Mii_name_251 = &H7FFE8
    Dim Mii_name_252 = &H807E8
    Dim Mii_name_253 = &H80FE8
    Dim Mii_name_254 = &H817E8
    Dim Mii_name_255 = &H81FE8
    Dim Mii_name_256 = &H827E8
    Dim Mii_name_257 = &H82FE8
    Dim Mii_name_258 = &H837E8
    Dim Mii_name_259 = &H83FE8
    Dim Mii_name_260 = &H847E8
    Dim Mii_name_261 = &H84FE8
    Dim Mii_name_262 = &H857E8
    Dim Mii_name_263 = &H85FE8
    Dim Mii_name_264 = &H867E8
    Dim Mii_name_265 = &H86FE8
    Dim Mii_name_266 = &H877E8
    Dim Mii_name_267 = &H87FE8
    Dim Mii_name_268 = &H887E8
    Dim Mii_name_269 = &H88FE8
    Dim Mii_name_270 = &H897E8
    Dim Mii_name_271 = &H89FE8
    Dim Mii_name_272 = &H8A7E8
    Dim Mii_name_273 = &H8AFE8
    Dim Mii_name_274 = &H8B7E8
    Dim Mii_name_275 = &H8BFE8
    Dim Mii_name_276 = &H8C7E8
    Dim Mii_name_277 = &H8CFE8
    Dim Mii_name_278 = &H8D7E8
    Dim Mii_name_279 = &H8DFE8
    Dim Mii_name_280 = &H8E7E8
    Dim Mii_name_281 = &H8EFE8
    Dim Mii_name_282 = &H8F7E8
    Dim Mii_name_283 = &H8FFE8
    Dim Mii_name_284 = &H907E8
    Dim Mii_name_285 = &H90FE8
    Dim Mii_name_286 = &H917E8
    Dim Mii_name_287 = &H91FE8
    Dim Mii_name_288 = &H927E8
    Dim Mii_name_289 = &H92FE8
    Dim Mii_name_290 = &H937E8
    Dim Mii_name_291 = &H93FE8
    Dim Mii_name_292 = &H947E8
    Dim Mii_name_293 = &H94FE8
    Dim Mii_name_294 = &H957E8
    Dim Mii_name_295 = &H95FE8
    Dim Mii_name_296 = &H967E8
    Dim Mii_name_297 = &H96FE8
    Dim Mii_name_298 = &H977E8
    Dim Mii_name_299 = &H97FE8
    Dim Mii_name_300 = &H987E8
    Dim Mii_name_301 = &H98FE8
    Dim Mii_name_302 = &H997E8
    Dim Mii_name_303 = &H99FE8
    Dim Mii_name_304 = &H9A7E8
    Dim Mii_name_305 = &H9AFE8
    Dim Mii_name_306 = &H9B7E8
    Dim Mii_name_307 = &H9BFE8
    Dim Mii_name_308 = &H9C7E8
    Dim Mii_name_309 = &H9CFE8
    Dim Mii_name_310 = &H9D7E8
    Dim Mii_name_311 = &H9DFE8
    Dim Mii_name_312 = &H9E7E8
    Dim Mii_name_313 = &H9EFE8
    Dim Mii_name_314 = &H9F7E8
    Dim Mii_name_315 = &H9FFE8
    Dim Mii_name_316 = &HA07E8
    Dim Mii_name_317 = &HA0FE8
    Dim Mii_name_318 = &HA17E8
    Dim Mii_name_319 = &HA1FE8
    Dim Mii_name_320 = &HA27E8
    Dim Mii_name_321 = &HA2FE8
    Dim Mii_name_322 = &HA37E8
    Dim Mii_name_323 = &HA3FE8
    Dim Mii_name_324 = &HA47E8
    Dim Mii_name_325 = &HA4FE8
    Dim Mii_name_326 = &HA57E8
    Dim Mii_name_327 = &HA5FE8
    Dim Mii_name_328 = &HA67E8
    Dim Mii_name_329 = &HA6FE8
    Dim Mii_name_330 = &HA77E8
    Dim Mii_name_331 = &HA7FE8
    Dim Mii_name_332 = &HA87E8
    Dim Mii_name_333 = &HA8FE8
    Dim Mii_name_334 = &HA97E8
    Dim Mii_name_335 = &HA9FE8
    Dim Mii_name_336 = &HAA7E8
    Dim Mii_name_337 = &HAAFE8
    Dim Mii_name_338 = &HAB7E8
    Dim Mii_name_339 = &HABFE8
    Dim Mii_name_340 = &HAC7E8
    Dim Mii_name_341 = &HACFE8
    Dim Mii_name_342 = &HAD7E8
    Dim Mii_name_343 = &HADFE8
    Dim Mii_name_344 = &HAE7E8
    Dim Mii_name_345 = &HAEFE8
    Dim Mii_name_346 = &HAF7E8
    Dim Mii_name_347 = &HAFFE8
    Dim Mii_name_348 = &HB07E8
    Dim Mii_name_349 = &HB0FE8
    Dim Mii_name_350 = &HB17E8
    Dim Mii_name_351 = &HB1FE8
    Dim Mii_name_352 = &HB27E8
    Dim Mii_name_353 = &HB2FE8
    Dim Mii_name_354 = &HB37E8
    Dim Mii_name_355 = &HB3FE8
    Dim Mii_name_356 = &HB47E8
    Dim Mii_name_357 = &HB4FE8
    Dim Mii_name_358 = &HB57E8
    Dim Mii_name_359 = &HB5FE8
    Dim Mii_name_360 = &HB67E8
    Dim Mii_name_361 = &HB6FE8
    Dim Mii_name_362 = &HB77E8
    Dim Mii_name_363 = &HB7FE8
    Dim Mii_name_364 = &HB87E8
    Dim Mii_name_365 = &HB8FE8
    Dim Mii_name_366 = &HB97E8
    Dim Mii_name_367 = &HB9FE8
    Dim Mii_name_368 = &HBA7E8
    Dim Mii_name_369 = &HBAFE8
    Dim Mii_name_370 = &HBB7E8
    Dim Mii_name_371 = &HBBFE8
    Dim Mii_name_372 = &HBC7E8
    Dim Mii_name_373 = &HBCFE8
    Dim Mii_name_374 = &HBD7E8
    Dim Mii_name_375 = &HBDFE8
    Dim Mii_name_376 = &HBE7E8
    Dim Mii_name_377 = &HBEFE8
    Dim Mii_name_378 = &HBF7E8
    Dim Mii_name_379 = &HBFFE8
    Dim Mii_name_380 = &HC07E8
    Dim Mii_name_381 = &HC0FE8
    Dim Mii_name_382 = &HC17E8
    Dim Mii_name_383 = &HC1FE8
    Dim Mii_name_384 = &HC27E8
    Dim Mii_name_385 = &HC2FE8
    Dim Mii_name_386 = &HC37E8
    Dim Mii_name_387 = &HC3FE8
    Dim Mii_name_388 = &HC47E8
    Dim Mii_name_389 = &HC4FE8
    Dim Mii_name_390 = &HC57E8
    Dim Mii_name_391 = &HC5FE8
    Dim Mii_name_392 = &HC67E8
    Dim Mii_name_393 = &HC6FE8
    Dim Mii_name_394 = &HC77E8
    Dim Mii_name_395 = &HC7FE8
    Dim Mii_name_396 = &HC87E8
    Dim Mii_name_397 = &HC8FE8
    Dim Mii_name_398 = &HC97E8
    Dim Mii_name_399 = &HC9FE8
    Dim Mii_name_400 = &HCA7E8
    Dim Mii_name_401 = &HCAFE8
    Dim Mii_name_402 = &HCB7E8
    Dim Mii_name_403 = &HCBFE8
    Dim Mii_name_404 = &HCC7E8
    Dim Mii_name_405 = &HCCFE8
    Dim Mii_name_406 = &HCD7E8
    Dim Mii_name_407 = &HCDFE8
    Dim Mii_name_408 = &HCE7E8
    Dim Mii_name_409 = &HCEFE8
    Dim Mii_name_410 = &HCF7E8
    Dim Mii_name_411 = &HCFFE8
    Dim Mii_name_412 = &HD07E8
    Dim Mii_name_413 = &HD0FE8
    Dim Mii_name_414 = &HD17E8
    Dim Mii_name_415 = &HD1FE8
    Dim Mii_name_416 = &HD27E8
    Dim Mii_name_417 = &HD2FE8
    Dim Mii_name_418 = &HD37E8
    Dim Mii_name_419 = &HD3FE8
    Dim Mii_name_420 = &HD47E8
    Dim Mii_name_421 = &HD4FE8
    Dim Mii_name_422 = &HD57E8
    Dim Mii_name_423 = &HD5FE8
    Dim Mii_name_424 = &HD67E8
    Dim Mii_name_425 = &HD6FE8
    Dim Mii_name_426 = &HD77E8
    Dim Mii_name_427 = &HD7FE8
    Dim Mii_name_428 = &HD87E8
    Dim Mii_name_429 = &HD8FE8
    Dim Mii_name_430 = &HD97E8
    Dim Mii_name_431 = &HD9FE8
    Dim Mii_name_432 = &HDA7E8
    Dim Mii_name_433 = &HDAFE8
    Dim Mii_name_434 = &HDB7E8
    Dim Mii_name_435 = &HDBFE8
    Dim Mii_name_436 = &HDC7E8
    Dim Mii_name_437 = &HDCFE8
    Dim Mii_name_438 = &HDD7E8
    Dim Mii_name_439 = &HDDFE8
    Dim Mii_name_440 = &HDE7E8
    Dim Mii_name_441 = &HDEFE8
    Dim Mii_name_442 = &HDF7E8
    Dim Mii_name_443 = &HDFFE8
    Dim Mii_name_444 = &HE07E8
    Dim Mii_name_445 = &HE0FE8
    Dim Mii_name_446 = &HE17E8
    Dim Mii_name_447 = &HE1FE8
    Dim Mii_name_448 = &HE27E8
    Dim Mii_name_449 = &HE2FE8
    Dim Mii_name_450 = &HE37E8
    Dim Mii_name_451 = &HE3FE8
    Dim Mii_name_452 = &HE47E8
    Dim Mii_name_453 = &HE4FE8
    Dim Mii_name_454 = &HE57E8
    Dim Mii_name_455 = &HE5FE8
    Dim Mii_name_456 = &HE67E8
    Dim Mii_name_457 = &HE6FE8
    Dim Mii_name_458 = &HE77E8
    Dim Mii_name_459 = &HE7FE8
    Dim Mii_name_460 = &HE87E8
    Dim Mii_name_461 = &HE8FE8
    Dim Mii_name_462 = &HE97E8
    Dim Mii_name_463 = &HE9FE8
    Dim Mii_name_464 = &HEA7E8
    Dim Mii_name_465 = &HEAFE8
    Dim Mii_name_466 = &HEB7E8
    Dim Mii_name_467 = &HEBFE8
    Dim Mii_name_468 = &HEC7E8
    Dim Mii_name_469 = &HECFE8
    Dim Mii_name_470 = &HED7E8
    Dim Mii_name_471 = &HEDFE8
    Dim Mii_name_472 = &HEE7E8
    Dim Mii_name_473 = &HEEFE8
    Dim Mii_name_474 = &HEF7E8
    Dim Mii_name_475 = &HEFFE8
    Dim Mii_name_476 = &HF07E8
    Dim Mii_name_477 = &HF0FE8
    Dim Mii_name_478 = &HF17E8
    Dim Mii_name_479 = &HF1FE8
    Dim Mii_name_480 = &HF27E8
    Dim Mii_name_481 = &HF2FE8
    Dim Mii_name_482 = &HF37E8
    Dim Mii_name_483 = &HF3FE8
    Dim Mii_name_484 = &HF47E8
    Dim Mii_name_485 = &HF4FE8
    Dim Mii_name_486 = &HF57E8
    Dim Mii_name_487 = &HF5FE8
    Dim Mii_name_488 = &HF67E8
    Dim Mii_name_489 = &HF6FE8
    Dim Mii_name_490 = &HF77E8
    Dim Mii_name_491 = &HF7FE8
    Dim Mii_name_492 = &HF87E8
    Dim Mii_name_493 = &HF8FE8
    Dim Mii_name_494 = &HF97E8
    Dim Mii_name_495 = &HF9FE8
    Dim Mii_name_496 = &HFA7E8
    Dim Mii_name_497 = &HFAFE8
    Dim Mii_name_498 = &HFB7E8
    Dim Mii_name_499 = &HFBFE8
    Dim Mii_name_500 = &HFC7E8
    Dim Mii_appareance_1 = &H3000
    Dim Mii_appareance_2 = &H3800
    Dim Mii_appareance_3 = &H4000
    Dim Mii_appareance_4 = &H4800
    Dim Mii_appareance_5 = &H5000
    Dim Mii_appareance_6 = &H5800
    Dim Mii_appareance_7 = &H6000
    Dim Mii_appareance_8 = &H6800
    Dim Mii_appareance_9 = &H7000
    Dim Mii_appareance_10 = &H7800
    Dim Mii_appareance_11 = &H8000
    Dim Mii_appareance_12 = &H8800
    Dim Mii_appareance_13 = &H9000
    Dim Mii_appareance_14 = &H9800
    Dim Mii_appareance_15 = &HA000
    Dim Mii_appareance_16 = &HA800
    Dim Mii_appareance_17 = &HB000
    Dim Mii_appareance_18 = &HB800
    Dim Mii_appareance_19 = &HC000
    Dim Mii_appareance_20 = &HC800
    Dim Mii_appareance_21 = &HD000
    Dim Mii_appareance_22 = &HD800
    Dim Mii_appareance_23 = &HE000
    Dim Mii_appareance_24 = &HE800
    Dim Mii_appareance_25 = &HF000
    Dim Mii_appareance_26 = &HF800
    Dim Mii_appareance_27 = &H10000
    Dim Mii_appareance_28 = &H10800
    Dim Mii_appareance_29 = &H11000
    Dim Mii_appareance_30 = &H11800
    Dim Mii_appareance_31 = &H12000
    Dim Mii_appareance_32 = &H12800
    Dim Mii_appareance_33 = &H13000
    Dim Mii_appareance_34 = &H13800
    Dim Mii_appareance_35 = &H14000
    Dim Mii_appareance_36 = &H14800
    Dim Mii_appareance_37 = &H15000
    Dim Mii_appareance_38 = &H15800
    Dim Mii_appareance_39 = &H16000
    Dim Mii_appareance_40 = &H16800
    Dim Mii_appareance_41 = &H17000
    Dim Mii_appareance_42 = &H17800
    Dim Mii_appareance_43 = &H18000
    Dim Mii_appareance_44 = &H18800
    Dim Mii_appareance_45 = &H19000
    Dim Mii_appareance_46 = &H19800
    Dim Mii_appareance_47 = &H1A000
    Dim Mii_appareance_48 = &H1A800
    Dim Mii_appareance_49 = &H1B000
    Dim Mii_appareance_50 = &H1B800
    Dim Mii_appareance_51 = &H1C000
    Dim Mii_appareance_52 = &H1C800
    Dim Mii_appareance_53 = &H1D000
    Dim Mii_appareance_54 = &H1D800
    Dim Mii_appareance_55 = &H1E000
    Dim Mii_appareance_56 = &H1E800
    Dim Mii_appareance_57 = &H1F000
    Dim Mii_appareance_58 = &H1F800
    Dim Mii_appareance_59 = &H20000
    Dim Mii_appareance_60 = &H20800
    Dim Mii_appareance_61 = &H21000
    Dim Mii_appareance_62 = &H21800
    Dim Mii_appareance_63 = &H22000
    Dim Mii_appareance_64 = &H22800
    Dim Mii_appareance_65 = &H23000
    Dim Mii_appareance_66 = &H23800
    Dim Mii_appareance_67 = &H24000
    Dim Mii_appareance_68 = &H24800
    Dim Mii_appareance_69 = &H25000
    Dim Mii_appareance_70 = &H25800
    Dim Mii_appareance_71 = &H26000
    Dim Mii_appareance_72 = &H26800
    Dim Mii_appareance_73 = &H27000
    Dim Mii_appareance_74 = &H27800
    Dim Mii_appareance_75 = &H28000
    Dim Mii_appareance_76 = &H28800
    Dim Mii_appareance_77 = &H29000
    Dim Mii_appareance_78 = &H29800
    Dim Mii_appareance_79 = &H2A000
    Dim Mii_appareance_80 = &H2A800
    Dim Mii_appareance_81 = &H2B000
    Dim Mii_appareance_82 = &H2B800
    Dim Mii_appareance_83 = &H2C000
    Dim Mii_appareance_84 = &H2C800
    Dim Mii_appareance_85 = &H2D000
    Dim Mii_appareance_86 = &H2D800
    Dim Mii_appareance_87 = &H2E000
    Dim Mii_appareance_88 = &H2E800
    Dim Mii_appareance_89 = &H2F000
    Dim Mii_appareance_90 = &H2F800
    Dim Mii_appareance_91 = &H30000
    Dim Mii_appareance_92 = &H30800
    Dim Mii_appareance_93 = &H31000
    Dim Mii_appareance_94 = &H31800
    Dim Mii_appareance_95 = &H32000
    Dim Mii_appareance_96 = &H32800
    Dim Mii_appareance_97 = &H33000
    Dim Mii_appareance_98 = &H33800
    Dim Mii_appareance_99 = &H34000
    Dim Mii_appareance_100 = &H34800
    Dim Mii_appareance_101 = &H35000
    Dim Mii_appareance_102 = &H35800
    Dim Mii_appareance_103 = &H36000
    Dim Mii_appareance_104 = &H36800
    Dim Mii_appareance_105 = &H37000
    Dim Mii_appareance_106 = &H37800
    Dim Mii_appareance_107 = &H38000
    Dim Mii_appareance_108 = &H38800
    Dim Mii_appareance_109 = &H39000
    Dim Mii_appareance_110 = &H39800
    Dim Mii_appareance_111 = &H3A000
    Dim Mii_appareance_112 = &H3A800
    Dim Mii_appareance_113 = &H3B000
    Dim Mii_appareance_114 = &H3B800
    Dim Mii_appareance_115 = &H3C000
    Dim Mii_appareance_116 = &H3C800
    Dim Mii_appareance_117 = &H3D000
    Dim Mii_appareance_118 = &H3D800
    Dim Mii_appareance_119 = &H3E000
    Dim Mii_appareance_120 = &H3E800
    Dim Mii_appareance_121 = &H3F000
    Dim Mii_appareance_122 = &H3F800
    Dim Mii_appareance_123 = &H40000
    Dim Mii_appareance_124 = &H40800
    Dim Mii_appareance_125 = &H41000
    Dim Mii_appareance_126 = &H41800
    Dim Mii_appareance_127 = &H42000
    Dim Mii_appareance_128 = &H42800
    Dim Mii_appareance_129 = &H43000
    Dim Mii_appareance_130 = &H43800
    Dim Mii_appareance_131 = &H44000
    Dim Mii_appareance_132 = &H44800
    Dim Mii_appareance_133 = &H45000
    Dim Mii_appareance_134 = &H45800
    Dim Mii_appareance_135 = &H46000
    Dim Mii_appareance_136 = &H46800
    Dim Mii_appareance_137 = &H47000
    Dim Mii_appareance_138 = &H47800
    Dim Mii_appareance_139 = &H48000
    Dim Mii_appareance_140 = &H48800
    Dim Mii_appareance_141 = &H49000
    Dim Mii_appareance_142 = &H49800
    Dim Mii_appareance_143 = &H4A000
    Dim Mii_appareance_144 = &H4A800
    Dim Mii_appareance_145 = &H4B000
    Dim Mii_appareance_146 = &H4B800
    Dim Mii_appareance_147 = &H4C000
    Dim Mii_appareance_148 = &H4C800
    Dim Mii_appareance_149 = &H4D000
    Dim Mii_appareance_150 = &H4D800
    Dim Mii_appareance_151 = &H4E000
    Dim Mii_appareance_152 = &H4E800
    Dim Mii_appareance_153 = &H4F000
    Dim Mii_appareance_154 = &H4F800
    Dim Mii_appareance_155 = &H50000
    Dim Mii_appareance_156 = &H50800
    Dim Mii_appareance_157 = &H51000
    Dim Mii_appareance_158 = &H51800
    Dim Mii_appareance_159 = &H52000
    Dim Mii_appareance_160 = &H52800
    Dim Mii_appareance_161 = &H53000
    Dim Mii_appareance_162 = &H53800
    Dim Mii_appareance_163 = &H54000
    Dim Mii_appareance_164 = &H54800
    Dim Mii_appareance_165 = &H55000
    Dim Mii_appareance_166 = &H55800
    Dim Mii_appareance_167 = &H56000
    Dim Mii_appareance_168 = &H56800
    Dim Mii_appareance_169 = &H57000
    Dim Mii_appareance_170 = &H57800
    Dim Mii_appareance_171 = &H58000
    Dim Mii_appareance_172 = &H58800
    Dim Mii_appareance_173 = &H59000
    Dim Mii_appareance_174 = &H59800
    Dim Mii_appareance_175 = &H5A000
    Dim Mii_appareance_176 = &H5A800
    Dim Mii_appareance_177 = &H5B000
    Dim Mii_appareance_178 = &H5B800
    Dim Mii_appareance_179 = &H5C000
    Dim Mii_appareance_180 = &H5C800
    Dim Mii_appareance_181 = &H5D000
    Dim Mii_appareance_182 = &H5D800
    Dim Mii_appareance_183 = &H5E000
    Dim Mii_appareance_184 = &H5E800
    Dim Mii_appareance_185 = &H5F000
    Dim Mii_appareance_186 = &H5F800
    Dim Mii_appareance_187 = &H60000
    Dim Mii_appareance_188 = &H60800
    Dim Mii_appareance_189 = &H61000
    Dim Mii_appareance_190 = &H61800
    Dim Mii_appareance_191 = &H62000
    Dim Mii_appareance_192 = &H62800
    Dim Mii_appareance_193 = &H63000
    Dim Mii_appareance_194 = &H63800
    Dim Mii_appareance_195 = &H64000
    Dim Mii_appareance_196 = &H64800
    Dim Mii_appareance_197 = &H65000
    Dim Mii_appareance_198 = &H65800
    Dim Mii_appareance_199 = &H66000
    Dim Mii_appareance_200 = &H66800
    Dim Mii_appareance_201 = &H67000
    Dim Mii_appareance_202 = &H67800
    Dim Mii_appareance_203 = &H68000
    Dim Mii_appareance_204 = &H68800
    Dim Mii_appareance_205 = &H69000
    Dim Mii_appareance_206 = &H69800
    Dim Mii_appareance_207 = &H6A000
    Dim Mii_appareance_208 = &H6A800
    Dim Mii_appareance_209 = &H6B000
    Dim Mii_appareance_210 = &H6B800
    Dim Mii_appareance_211 = &H6C000
    Dim Mii_appareance_212 = &H6C800
    Dim Mii_appareance_213 = &H6D000
    Dim Mii_appareance_214 = &H6D800
    Dim Mii_appareance_215 = &H6E000
    Dim Mii_appareance_216 = &H6E800
    Dim Mii_appareance_217 = &H6F000
    Dim Mii_appareance_218 = &H6F800
    Dim Mii_appareance_219 = &H70000
    Dim Mii_appareance_220 = &H70800
    Dim Mii_appareance_221 = &H71000
    Dim Mii_appareance_222 = &H71800
    Dim Mii_appareance_223 = &H72000
    Dim Mii_appareance_224 = &H72800
    Dim Mii_appareance_225 = &H73000
    Dim Mii_appareance_226 = &H73800
    Dim Mii_appareance_227 = &H74000
    Dim Mii_appareance_228 = &H74800
    Dim Mii_appareance_229 = &H75000
    Dim Mii_appareance_230 = &H75800
    Dim Mii_appareance_231 = &H76000
    Dim Mii_appareance_232 = &H76800
    Dim Mii_appareance_233 = &H77000
    Dim Mii_appareance_234 = &H77800
    Dim Mii_appareance_235 = &H78000
    Dim Mii_appareance_236 = &H78800
    Dim Mii_appareance_237 = &H79000
    Dim Mii_appareance_238 = &H79800
    Dim Mii_appareance_239 = &H7A000
    Dim Mii_appareance_240 = &H7A800
    Dim Mii_appareance_241 = &H7B000
    Dim Mii_appareance_242 = &H7B800
    Dim Mii_appareance_243 = &H7C000
    Dim Mii_appareance_244 = &H7C800
    Dim Mii_appareance_245 = &H7D000
    Dim Mii_appareance_246 = &H7D800
    Dim Mii_appareance_247 = &H7E000
    Dim Mii_appareance_248 = &H7E800
    Dim Mii_appareance_249 = &H7F000
    Dim Mii_appareance_250 = &H7F800
    Dim Mii_appareance_251 = &H80000
    Dim Mii_appareance_252 = &H80800
    Dim Mii_appareance_253 = &H81000
    Dim Mii_appareance_254 = &H81800
    Dim Mii_appareance_255 = &H82000
    Dim Mii_appareance_256 = &H82800
    Dim Mii_appareance_257 = &H83000
    Dim Mii_appareance_258 = &H83800
    Dim Mii_appareance_259 = &H84000
    Dim Mii_appareance_260 = &H84800
    Dim Mii_appareance_261 = &H85000
    Dim Mii_appareance_262 = &H85800
    Dim Mii_appareance_263 = &H86000
    Dim Mii_appareance_264 = &H86800
    Dim Mii_appareance_265 = &H87000
    Dim Mii_appareance_266 = &H87800
    Dim Mii_appareance_267 = &H88000
    Dim Mii_appareance_268 = &H88800
    Dim Mii_appareance_269 = &H89000
    Dim Mii_appareance_270 = &H89800
    Dim Mii_appareance_271 = &H8A000
    Dim Mii_appareance_272 = &H8A800
    Dim Mii_appareance_273 = &H8B000
    Dim Mii_appareance_274 = &H8B800
    Dim Mii_appareance_275 = &H8C000
    Dim Mii_appareance_276 = &H8C800
    Dim Mii_appareance_277 = &H8D000
    Dim Mii_appareance_278 = &H8D800
    Dim Mii_appareance_279 = &H8E000
    Dim Mii_appareance_280 = &H8E800
    Dim Mii_appareance_281 = &H8F000
    Dim Mii_appareance_282 = &H8F800
    Dim Mii_appareance_283 = &H90000
    Dim Mii_appareance_284 = &H90800
    Dim Mii_appareance_285 = &H91000
    Dim Mii_appareance_286 = &H91800
    Dim Mii_appareance_287 = &H92000
    Dim Mii_appareance_288 = &H92800
    Dim Mii_appareance_289 = &H93000
    Dim Mii_appareance_290 = &H93800
    Dim Mii_appareance_291 = &H94000
    Dim Mii_appareance_292 = &H94800
    Dim Mii_appareance_293 = &H95000
    Dim Mii_appareance_294 = &H95800
    Dim Mii_appareance_295 = &H96000
    Dim Mii_appareance_296 = &H96800
    Dim Mii_appareance_297 = &H97000
    Dim Mii_appareance_298 = &H97800
    Dim Mii_appareance_299 = &H98000
    Dim Mii_appareance_300 = &H98800
    Dim Mii_appareance_301 = &H99000
    Dim Mii_appareance_302 = &H99800
    Dim Mii_appareance_303 = &H9A000
    Dim Mii_appareance_304 = &H9A800
    Dim Mii_appareance_305 = &H9B000
    Dim Mii_appareance_306 = &H9B800
    Dim Mii_appareance_307 = &H9C000
    Dim Mii_appareance_308 = &H9C800
    Dim Mii_appareance_309 = &H9D000
    Dim Mii_appareance_310 = &H9D800
    Dim Mii_appareance_311 = &H9E000
    Dim Mii_appareance_312 = &H9E800
    Dim Mii_appareance_313 = &H9F000
    Dim Mii_appareance_314 = &H9F800
    Dim Mii_appareance_315 = &HA0000
    Dim Mii_appareance_316 = &HA0800
    Dim Mii_appareance_317 = &HA1000
    Dim Mii_appareance_318 = &HA1800
    Dim Mii_appareance_319 = &HA2000
    Dim Mii_appareance_320 = &HA2800
    Dim Mii_appareance_321 = &HA3000
    Dim Mii_appareance_322 = &HA3800
    Dim Mii_appareance_323 = &HA4000
    Dim Mii_appareance_324 = &HA4800
    Dim Mii_appareance_325 = &HA5000
    Dim Mii_appareance_326 = &HA5800
    Dim Mii_appareance_327 = &HA6000
    Dim Mii_appareance_328 = &HA6800
    Dim Mii_appareance_329 = &HA7000
    Dim Mii_appareance_330 = &HA7800
    Dim Mii_appareance_331 = &HA8000
    Dim Mii_appareance_332 = &HA8800
    Dim Mii_appareance_333 = &HA9000
    Dim Mii_appareance_334 = &HA9800
    Dim Mii_appareance_335 = &HAA000
    Dim Mii_appareance_336 = &HAA800
    Dim Mii_appareance_337 = &HAB000
    Dim Mii_appareance_338 = &HAB800
    Dim Mii_appareance_339 = &HAC000
    Dim Mii_appareance_340 = &HAC800
    Dim Mii_appareance_341 = &HAD000
    Dim Mii_appareance_342 = &HAD800
    Dim Mii_appareance_343 = &HAE000
    Dim Mii_appareance_344 = &HAE800
    Dim Mii_appareance_345 = &HAF000
    Dim Mii_appareance_346 = &HAF800
    Dim Mii_appareance_347 = &HB0000
    Dim Mii_appareance_348 = &HB0800
    Dim Mii_appareance_349 = &HB1000
    Dim Mii_appareance_350 = &HB1800
    Dim Mii_appareance_351 = &HB2000
    Dim Mii_appareance_352 = &HB2800
    Dim Mii_appareance_353 = &HB3000
    Dim Mii_appareance_354 = &HB3800
    Dim Mii_appareance_355 = &HB4000
    Dim Mii_appareance_356 = &HB4800
    Dim Mii_appareance_357 = &HB5000
    Dim Mii_appareance_358 = &HB5800
    Dim Mii_appareance_359 = &HB6000
    Dim Mii_appareance_360 = &HB6800
    Dim Mii_appareance_361 = &HB7000
    Dim Mii_appareance_362 = &HB7800
    Dim Mii_appareance_363 = &HB8000
    Dim Mii_appareance_364 = &HB8800
    Dim Mii_appareance_365 = &HB9000
    Dim Mii_appareance_366 = &HB9800
    Dim Mii_appareance_367 = &HBA000
    Dim Mii_appareance_368 = &HBA800
    Dim Mii_appareance_369 = &HBB000
    Dim Mii_appareance_370 = &HBB800
    Dim Mii_appareance_371 = &HBC000
    Dim Mii_appareance_372 = &HBC800
    Dim Mii_appareance_373 = &HBD000
    Dim Mii_appareance_374 = &HBD800
    Dim Mii_appareance_375 = &HBE000
    Dim Mii_appareance_376 = &HBE800
    Dim Mii_appareance_377 = &HBF000
    Dim Mii_appareance_378 = &HBF800
    Dim Mii_appareance_379 = &HC0000
    Dim Mii_appareance_380 = &HC0800
    Dim Mii_appareance_381 = &HC1000
    Dim Mii_appareance_382 = &HC1800
    Dim Mii_appareance_383 = &HC2000
    Dim Mii_appareance_384 = &HC2800
    Dim Mii_appareance_385 = &HC3000
    Dim Mii_appareance_386 = &HC3800
    Dim Mii_appareance_387 = &HC4000
    Dim Mii_appareance_388 = &HC4800
    Dim Mii_appareance_389 = &HC5000
    Dim Mii_appareance_390 = &HC5800
    Dim Mii_appareance_391 = &HC6000
    Dim Mii_appareance_392 = &HC6800
    Dim Mii_appareance_393 = &HC7000
    Dim Mii_appareance_394 = &HC7800
    Dim Mii_appareance_395 = &HC8000
    Dim Mii_appareance_396 = &HC8800
    Dim Mii_appareance_397 = &HC9000
    Dim Mii_appareance_398 = &HC9800
    Dim Mii_appareance_399 = &HCA000
    Dim Mii_appareance_400 = &HCA800
    Dim Mii_appareance_401 = &HCB000
    Dim Mii_appareance_402 = &HCB800
    Dim Mii_appareance_403 = &HCC000
    Dim Mii_appareance_404 = &HCC800
    Dim Mii_appareance_405 = &HCD000
    Dim Mii_appareance_406 = &HCD800
    Dim Mii_appareance_407 = &HCE000
    Dim Mii_appareance_408 = &HCE800
    Dim Mii_appareance_409 = &HCF000
    Dim Mii_appareance_410 = &HCF800
    Dim Mii_appareance_411 = &HD0000
    Dim Mii_appareance_412 = &HD0800
    Dim Mii_appareance_413 = &HD1000
    Dim Mii_appareance_414 = &HD1800
    Dim Mii_appareance_415 = &HD2000
    Dim Mii_appareance_416 = &HD2800
    Dim Mii_appareance_417 = &HD3000
    Dim Mii_appareance_418 = &HD3800
    Dim Mii_appareance_419 = &HD4000
    Dim Mii_appareance_420 = &HD4800
    Dim Mii_appareance_421 = &HD5000
    Dim Mii_appareance_422 = &HD5800
    Dim Mii_appareance_423 = &HD6000
    Dim Mii_appareance_424 = &HD6800
    Dim Mii_appareance_425 = &HD7000
    Dim Mii_appareance_426 = &HD7800
    Dim Mii_appareance_427 = &HD8000
    Dim Mii_appareance_428 = &HD8800
    Dim Mii_appareance_429 = &HD9000
    Dim Mii_appareance_430 = &HD9800
    Dim Mii_appareance_431 = &HDA000
    Dim Mii_appareance_432 = &HDA800
    Dim Mii_appareance_433 = &HDB000
    Dim Mii_appareance_434 = &HDB800
    Dim Mii_appareance_435 = &HDC000
    Dim Mii_appareance_436 = &HDC800
    Dim Mii_appareance_437 = &HDD000
    Dim Mii_appareance_438 = &HDD800
    Dim Mii_appareance_439 = &HDE000
    Dim Mii_appareance_440 = &HDE800
    Dim Mii_appareance_441 = &HDF000
    Dim Mii_appareance_442 = &HDF800
    Dim Mii_appareance_443 = &HE0000
    Dim Mii_appareance_444 = &HE0800
    Dim Mii_appareance_445 = &HE1000
    Dim Mii_appareance_446 = &HE1800
    Dim Mii_appareance_447 = &HE2000
    Dim Mii_appareance_448 = &HE2800
    Dim Mii_appareance_449 = &HE3000
    Dim Mii_appareance_450 = &HE3800
    Dim Mii_appareance_451 = &HE4000
    Dim Mii_appareance_452 = &HE4800
    Dim Mii_appareance_453 = &HE5000
    Dim Mii_appareance_454 = &HE5800
    Dim Mii_appareance_455 = &HE6000
    Dim Mii_appareance_456 = &HE6800
    Dim Mii_appareance_457 = &HE7000
    Dim Mii_appareance_458 = &HE7800
    Dim Mii_appareance_459 = &HE8000
    Dim Mii_appareance_460 = &HE8800
    Dim Mii_appareance_461 = &HE9000
    Dim Mii_appareance_462 = &HE9800
    Dim Mii_appareance_463 = &HEA000
    Dim Mii_appareance_464 = &HEA800
    Dim Mii_appareance_465 = &HEB000
    Dim Mii_appareance_466 = &HEB800
    Dim Mii_appareance_467 = &HEC000
    Dim Mii_appareance_468 = &HEC800
    Dim Mii_appareance_469 = &HED000
    Dim Mii_appareance_470 = &HED800
    Dim Mii_appareance_471 = &HEE000
    Dim Mii_appareance_472 = &HEE800
    Dim Mii_appareance_473 = &HEF000
    Dim Mii_appareance_474 = &HEF800
    Dim Mii_appareance_475 = &HF0000
    Dim Mii_appareance_476 = &HF0800
    Dim Mii_appareance_477 = &HF1000
    Dim Mii_appareance_478 = &HF1800
    Dim Mii_appareance_479 = &HF2000
    Dim Mii_appareance_480 = &HF2800
    Dim Mii_appareance_481 = &HF3000
    Dim Mii_appareance_482 = &HF3800
    Dim Mii_appareance_483 = &HF4000
    Dim Mii_appareance_484 = &HF4800
    Dim Mii_appareance_485 = &HF5000
    Dim Mii_appareance_486 = &HF5800
    Dim Mii_appareance_487 = &HF6000
    Dim Mii_appareance_488 = &HF6800
    Dim Mii_appareance_489 = &HF7000
    Dim Mii_appareance_490 = &HF7800
    Dim Mii_appareance_491 = &HF8000
    Dim Mii_appareance_492 = &HF8800
    Dim Mii_appareance_493 = &HF9000
    Dim Mii_appareance_494 = &HF9800
    Dim Mii_appareance_495 = &HFA000
    Dim Mii_appareance_496 = &HFA800
    Dim Mii_appareance_497 = &HFB000
    Dim Mii_appareance_498 = &HFB800
    Dim Mii_appareance_499 = &HFC000
    Dim Mii_appareance_500 = &HFC800

    'base
    Private Sub Icon_close_Click(sender As Object, e As EventArgs) Handles Icon_close.Click
        My.Settings.Para_ckupdate = 0
        Me.Close()
    End Sub

    Private Sub Icon_close_MouseMove(sender As Object, e As EventArgs) Handles Icon_close.MouseMove
        Icon_close.Image = My.Resources.icon_close_red
    End Sub

    Private Sub Icon_close_MouseLeave(sender As Object, e As EventArgs) Handles Icon_close.MouseLeave
        Icon_close.Image = My.Resources.icon_close
    End Sub

    Private Sub TLSE_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseDown, MSE_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MousedwnX = e.X
            MousedwnY = e.Y
        End If
    End Sub

    Private Sub MSE_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseUp, MSE_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MSE_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles MSE_header.MouseMove, MSE_title.MouseMove
        If IsFormBeingDragged = True Then
            Dim tmp As Point = New Point()
            tmp.X = Me.Location.X + (e.X - MousedwnX)
            tmp.Y = Me.Location.Y + (e.Y - MousedwnY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Private Sub Icon_minimize_Click(sender As Object, e As EventArgs) Handles Icon_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Icon_minimize_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_minimize.MouseMove
        Icon_minimize.Image = My.Resources.icon_minimize_red
    End Sub

    Private Sub Icon_minimize_MouseLeave(sender As Object, e As EventArgs) Handles Icon_minimize.MouseLeave
        Icon_minimize.Image = My.Resources.icon_minimize
    End Sub

    Private Sub Icon_menu_Click(sender As Object, e As EventArgs) Handles Icon_menu.Click
        MSE_hub.Show()
        Me.Close()
    End Sub
    'end base

    'keep settings
    Private Sub MSE_transferMii_FormClosing(sender As Object, e As EventArgs) Handles Me.FormClosing
        MSE_hub.Text_filepath.Text = mainsav
    End Sub
    'end keep settings

    'load process
    Private Sub MSE_transferMii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MSE_hub.Text_filepath.Text = Nothing Then
        Else
            ReadteamMiiname()
        End If
    End Sub

    Public Sub ReadteamMiiname()
        Try
            Dim ReadMiiname As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            ReadMiiname.Position = Mii_name_1
            Select_Mii.Items.Item(0) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_2
            Select_Mii.Items.Item(1) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_3
            Select_Mii.Items.Item(2) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_4
            Select_Mii.Items.Item(3) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_5
            Select_Mii.Items.Item(4) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_6
            Select_Mii.Items.Item(5) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_7
            Select_Mii.Items.Item(6) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_8
            Select_Mii.Items.Item(7) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_9
            Select_Mii.Items.Item(8) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_10
            Select_Mii.Items.Item(9) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_11
            Select_Mii.Items.Item(10) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_12
            Select_Mii.Items.Item(11) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_13
            Select_Mii.Items.Item(12) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_14
            Select_Mii.Items.Item(13) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_15
            Select_Mii.Items.Item(14) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_16
            Select_Mii.Items.Item(15) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_17
            Select_Mii.Items.Item(16) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_18
            Select_Mii.Items.Item(17) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_19
            Select_Mii.Items.Item(18) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_20
            Select_Mii.Items.Item(19) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_21
            Select_Mii.Items.Item(20) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_22
            Select_Mii.Items.Item(21) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_23
            Select_Mii.Items.Item(22) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_24
            Select_Mii.Items.Item(23) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_25
            Select_Mii.Items.Item(24) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_26
            Select_Mii.Items.Item(25) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_27
            Select_Mii.Items.Item(26) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_28
            Select_Mii.Items.Item(27) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_29
            Select_Mii.Items.Item(28) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_30
            Select_Mii.Items.Item(29) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_31
            Select_Mii.Items.Item(30) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_32
            Select_Mii.Items.Item(31) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_33
            Select_Mii.Items.Item(32) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_34
            Select_Mii.Items.Item(33) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_35
            Select_Mii.Items.Item(34) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_36
            Select_Mii.Items.Item(35) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_37
            Select_Mii.Items.Item(36) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_38
            Select_Mii.Items.Item(37) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_39
            Select_Mii.Items.Item(38) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_40
            Select_Mii.Items.Item(39) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_41
            Select_Mii.Items.Item(40) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_42
            Select_Mii.Items.Item(41) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_43
            Select_Mii.Items.Item(42) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_44
            Select_Mii.Items.Item(43) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_45
            Select_Mii.Items.Item(44) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_46
            Select_Mii.Items.Item(45) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_47
            Select_Mii.Items.Item(46) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_48
            Select_Mii.Items.Item(47) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_49
            Select_Mii.Items.Item(48) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_50
            Select_Mii.Items.Item(49) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_51
            Select_Mii.Items.Item(50) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_52
            Select_Mii.Items.Item(51) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_53
            Select_Mii.Items.Item(52) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_54
            Select_Mii.Items.Item(53) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_55
            Select_Mii.Items.Item(54) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_56
            Select_Mii.Items.Item(55) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_57
            Select_Mii.Items.Item(56) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_58
            Select_Mii.Items.Item(57) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_59
            Select_Mii.Items.Item(58) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_60
            Select_Mii.Items.Item(59) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_61
            Select_Mii.Items.Item(60) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_62
            Select_Mii.Items.Item(61) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_63
            Select_Mii.Items.Item(62) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_64
            Select_Mii.Items.Item(63) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_65
            Select_Mii.Items.Item(64) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_66
            Select_Mii.Items.Item(65) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_67
            Select_Mii.Items.Item(66) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_68
            Select_Mii.Items.Item(67) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_69
            Select_Mii.Items.Item(68) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_70
            Select_Mii.Items.Item(69) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_71
            Select_Mii.Items.Item(70) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_72
            Select_Mii.Items.Item(71) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_73
            Select_Mii.Items.Item(72) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_74
            Select_Mii.Items.Item(73) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_75
            Select_Mii.Items.Item(74) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_76
            Select_Mii.Items.Item(75) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_77
            Select_Mii.Items.Item(76) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_78
            Select_Mii.Items.Item(77) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_79
            Select_Mii.Items.Item(78) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_80
            Select_Mii.Items.Item(79) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_81
            Select_Mii.Items.Item(80) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_82
            Select_Mii.Items.Item(81) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_83
            Select_Mii.Items.Item(82) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_84
            Select_Mii.Items.Item(83) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_85
            Select_Mii.Items.Item(84) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_86
            Select_Mii.Items.Item(85) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_87
            Select_Mii.Items.Item(86) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_88
            Select_Mii.Items.Item(87) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_89
            Select_Mii.Items.Item(88) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_90
            Select_Mii.Items.Item(89) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_91
            Select_Mii.Items.Item(90) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_92
            Select_Mii.Items.Item(91) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_93
            Select_Mii.Items.Item(92) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_94
            Select_Mii.Items.Item(93) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_95
            Select_Mii.Items.Item(94) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_96
            Select_Mii.Items.Item(95) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_97
            Select_Mii.Items.Item(96) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_98
            Select_Mii.Items.Item(97) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_99
            Select_Mii.Items.Item(98) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_100
            Select_Mii.Items.Item(99) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_101
            Select_Mii.Items.Item(100) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_102
            Select_Mii.Items.Item(101) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_103
            Select_Mii.Items.Item(102) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_104
            Select_Mii.Items.Item(103) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_105
            Select_Mii.Items.Item(104) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_106
            Select_Mii.Items.Item(105) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_107
            Select_Mii.Items.Item(106) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_108
            Select_Mii.Items.Item(107) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_109
            Select_Mii.Items.Item(108) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_110
            Select_Mii.Items.Item(109) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_111
            Select_Mii.Items.Item(110) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_112
            Select_Mii.Items.Item(111) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_113
            Select_Mii.Items.Item(112) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_114
            Select_Mii.Items.Item(113) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_115
            Select_Mii.Items.Item(114) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_116
            Select_Mii.Items.Item(115) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_117
            Select_Mii.Items.Item(116) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_118
            Select_Mii.Items.Item(117) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_119
            Select_Mii.Items.Item(118) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_120
            Select_Mii.Items.Item(119) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_121
            Select_Mii.Items.Item(120) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_122
            Select_Mii.Items.Item(121) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_123
            Select_Mii.Items.Item(122) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_124
            Select_Mii.Items.Item(123) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_125
            Select_Mii.Items.Item(124) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_126
            Select_Mii.Items.Item(125) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_127
            Select_Mii.Items.Item(126) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_128
            Select_Mii.Items.Item(127) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_129
            Select_Mii.Items.Item(128) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_130
            Select_Mii.Items.Item(129) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_131
            Select_Mii.Items.Item(130) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_132
            Select_Mii.Items.Item(131) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_133
            Select_Mii.Items.Item(132) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_134
            Select_Mii.Items.Item(133) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_135
            Select_Mii.Items.Item(134) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_136
            Select_Mii.Items.Item(135) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_137
            Select_Mii.Items.Item(136) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_138
            Select_Mii.Items.Item(137) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_139
            Select_Mii.Items.Item(138) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_140
            Select_Mii.Items.Item(139) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_141
            Select_Mii.Items.Item(140) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_142
            Select_Mii.Items.Item(141) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_143
            Select_Mii.Items.Item(142) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_144
            Select_Mii.Items.Item(143) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_145
            Select_Mii.Items.Item(144) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_146
            Select_Mii.Items.Item(145) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_147
            Select_Mii.Items.Item(146) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_148
            Select_Mii.Items.Item(147) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_149
            Select_Mii.Items.Item(148) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_150
            Select_Mii.Items.Item(149) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_151
            Select_Mii.Items.Item(150) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_152
            Select_Mii.Items.Item(151) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_153
            Select_Mii.Items.Item(152) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_154
            Select_Mii.Items.Item(153) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_155
            Select_Mii.Items.Item(154) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_156
            Select_Mii.Items.Item(155) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_157
            Select_Mii.Items.Item(156) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_158
            Select_Mii.Items.Item(157) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_159
            Select_Mii.Items.Item(158) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_160
            Select_Mii.Items.Item(159) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_161
            Select_Mii.Items.Item(160) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_162
            Select_Mii.Items.Item(161) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_163
            Select_Mii.Items.Item(162) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_164
            Select_Mii.Items.Item(163) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_165
            Select_Mii.Items.Item(164) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_166
            Select_Mii.Items.Item(165) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_167
            Select_Mii.Items.Item(166) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_168
            Select_Mii.Items.Item(167) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_169
            Select_Mii.Items.Item(168) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_170
            Select_Mii.Items.Item(169) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_171
            Select_Mii.Items.Item(170) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_172
            Select_Mii.Items.Item(171) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_173
            Select_Mii.Items.Item(172) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_174
            Select_Mii.Items.Item(173) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_175
            Select_Mii.Items.Item(174) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_176
            Select_Mii.Items.Item(175) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_177
            Select_Mii.Items.Item(176) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_178
            Select_Mii.Items.Item(177) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_179
            Select_Mii.Items.Item(178) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_180
            Select_Mii.Items.Item(179) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_181
            Select_Mii.Items.Item(180) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_182
            Select_Mii.Items.Item(181) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_183
            Select_Mii.Items.Item(182) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_184
            Select_Mii.Items.Item(183) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_185
            Select_Mii.Items.Item(184) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_186
            Select_Mii.Items.Item(185) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_187
            Select_Mii.Items.Item(186) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_188
            Select_Mii.Items.Item(187) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_189
            Select_Mii.Items.Item(188) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_190
            Select_Mii.Items.Item(189) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_191
            Select_Mii.Items.Item(190) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_192
            Select_Mii.Items.Item(191) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_193
            Select_Mii.Items.Item(192) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_194
            Select_Mii.Items.Item(193) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_195
            Select_Mii.Items.Item(194) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_196
            Select_Mii.Items.Item(195) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_197
            Select_Mii.Items.Item(196) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_198
            Select_Mii.Items.Item(197) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_199
            Select_Mii.Items.Item(198) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_200
            Select_Mii.Items.Item(199) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_201
            Select_Mii.Items.Item(200) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_202
            Select_Mii.Items.Item(201) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_203
            Select_Mii.Items.Item(202) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_204
            Select_Mii.Items.Item(203) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_205
            Select_Mii.Items.Item(204) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_206
            Select_Mii.Items.Item(205) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_207
            Select_Mii.Items.Item(206) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_208
            Select_Mii.Items.Item(207) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_209
            Select_Mii.Items.Item(208) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_210
            Select_Mii.Items.Item(209) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_211
            Select_Mii.Items.Item(210) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_212
            Select_Mii.Items.Item(211) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_213
            Select_Mii.Items.Item(212) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_214
            Select_Mii.Items.Item(213) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_215
            Select_Mii.Items.Item(214) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_216
            Select_Mii.Items.Item(215) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_217
            Select_Mii.Items.Item(216) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_218
            Select_Mii.Items.Item(217) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_219
            Select_Mii.Items.Item(218) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_220
            Select_Mii.Items.Item(219) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_221
            Select_Mii.Items.Item(220) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_222
            Select_Mii.Items.Item(221) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_223
            Select_Mii.Items.Item(222) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_224
            Select_Mii.Items.Item(223) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_225
            Select_Mii.Items.Item(224) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_226
            Select_Mii.Items.Item(225) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_227
            Select_Mii.Items.Item(226) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_228
            Select_Mii.Items.Item(227) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_229
            Select_Mii.Items.Item(228) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_230
            Select_Mii.Items.Item(229) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_231
            Select_Mii.Items.Item(230) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_232
            Select_Mii.Items.Item(231) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_233
            Select_Mii.Items.Item(232) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_234
            Select_Mii.Items.Item(233) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_235
            Select_Mii.Items.Item(234) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_236
            Select_Mii.Items.Item(235) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_237
            Select_Mii.Items.Item(236) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_238
            Select_Mii.Items.Item(237) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_239
            Select_Mii.Items.Item(238) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_240
            Select_Mii.Items.Item(239) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_241
            Select_Mii.Items.Item(240) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_242
            Select_Mii.Items.Item(241) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_243
            Select_Mii.Items.Item(242) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_244
            Select_Mii.Items.Item(243) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_245
            Select_Mii.Items.Item(244) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_246
            Select_Mii.Items.Item(245) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_247
            Select_Mii.Items.Item(246) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_248
            Select_Mii.Items.Item(247) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_249
            Select_Mii.Items.Item(248) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_250
            Select_Mii.Items.Item(249) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_251
            Select_Mii.Items.Item(250) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_252
            Select_Mii.Items.Item(251) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_253
            Select_Mii.Items.Item(252) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_254
            Select_Mii.Items.Item(253) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_255
            Select_Mii.Items.Item(254) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_256
            Select_Mii.Items.Item(255) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_257
            Select_Mii.Items.Item(256) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_258
            Select_Mii.Items.Item(257) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_259
            Select_Mii.Items.Item(258) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_260
            Select_Mii.Items.Item(259) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_261
            Select_Mii.Items.Item(260) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_262
            Select_Mii.Items.Item(261) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_263
            Select_Mii.Items.Item(262) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_264
            Select_Mii.Items.Item(263) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_265
            Select_Mii.Items.Item(264) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_266
            Select_Mii.Items.Item(265) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_267
            Select_Mii.Items.Item(266) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_268
            Select_Mii.Items.Item(267) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_269
            Select_Mii.Items.Item(268) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_270
            Select_Mii.Items.Item(269) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_271
            Select_Mii.Items.Item(270) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_272
            Select_Mii.Items.Item(271) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_273
            Select_Mii.Items.Item(272) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_274
            Select_Mii.Items.Item(273) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_275
            Select_Mii.Items.Item(274) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_276
            Select_Mii.Items.Item(275) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_277
            Select_Mii.Items.Item(276) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_278
            Select_Mii.Items.Item(277) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_279
            Select_Mii.Items.Item(278) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_280
            Select_Mii.Items.Item(279) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_281
            Select_Mii.Items.Item(280) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_282
            Select_Mii.Items.Item(281) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_283
            Select_Mii.Items.Item(282) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_284
            Select_Mii.Items.Item(283) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_285
            Select_Mii.Items.Item(284) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_286
            Select_Mii.Items.Item(285) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_287
            Select_Mii.Items.Item(286) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_288
            Select_Mii.Items.Item(287) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_289
            Select_Mii.Items.Item(288) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_290
            Select_Mii.Items.Item(289) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_291
            Select_Mii.Items.Item(290) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_292
            Select_Mii.Items.Item(291) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_293
            Select_Mii.Items.Item(292) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_294
            Select_Mii.Items.Item(293) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_295
            Select_Mii.Items.Item(294) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_296
            Select_Mii.Items.Item(295) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_297
            Select_Mii.Items.Item(296) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_298
            Select_Mii.Items.Item(297) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_299
            Select_Mii.Items.Item(298) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_300
            Select_Mii.Items.Item(299) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_301
            Select_Mii.Items.Item(300) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_302
            Select_Mii.Items.Item(301) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_303
            Select_Mii.Items.Item(302) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_304
            Select_Mii.Items.Item(303) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_305
            Select_Mii.Items.Item(304) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_306
            Select_Mii.Items.Item(305) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_307
            Select_Mii.Items.Item(306) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_308
            Select_Mii.Items.Item(307) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_309
            Select_Mii.Items.Item(308) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_310
            Select_Mii.Items.Item(309) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_311
            Select_Mii.Items.Item(310) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_312
            Select_Mii.Items.Item(311) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_313
            Select_Mii.Items.Item(312) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_314
            Select_Mii.Items.Item(313) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_315
            Select_Mii.Items.Item(314) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_316
            Select_Mii.Items.Item(315) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_317
            Select_Mii.Items.Item(316) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_318
            Select_Mii.Items.Item(317) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_319
            Select_Mii.Items.Item(318) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_320
            Select_Mii.Items.Item(319) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_321
            Select_Mii.Items.Item(320) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_322
            Select_Mii.Items.Item(321) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_323
            Select_Mii.Items.Item(322) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_324
            Select_Mii.Items.Item(323) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_325
            Select_Mii.Items.Item(324) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_326
            Select_Mii.Items.Item(325) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_327
            Select_Mii.Items.Item(326) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_328
            Select_Mii.Items.Item(327) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_329
            Select_Mii.Items.Item(328) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_330
            Select_Mii.Items.Item(329) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_331
            Select_Mii.Items.Item(330) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_332
            Select_Mii.Items.Item(331) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_333
            Select_Mii.Items.Item(332) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_334
            Select_Mii.Items.Item(333) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_335
            Select_Mii.Items.Item(334) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_336
            Select_Mii.Items.Item(335) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_337
            Select_Mii.Items.Item(336) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_338
            Select_Mii.Items.Item(337) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_339
            Select_Mii.Items.Item(338) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_340
            Select_Mii.Items.Item(339) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_341
            Select_Mii.Items.Item(340) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_342
            Select_Mii.Items.Item(341) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_343
            Select_Mii.Items.Item(342) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_344
            Select_Mii.Items.Item(343) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_345
            Select_Mii.Items.Item(344) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_346
            Select_Mii.Items.Item(345) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_347
            Select_Mii.Items.Item(346) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_348
            Select_Mii.Items.Item(347) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_349
            Select_Mii.Items.Item(348) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_350
            Select_Mii.Items.Item(349) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_351
            Select_Mii.Items.Item(350) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_352
            Select_Mii.Items.Item(351) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_353
            Select_Mii.Items.Item(352) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_354
            Select_Mii.Items.Item(353) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_355
            Select_Mii.Items.Item(354) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_356
            Select_Mii.Items.Item(355) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_357
            Select_Mii.Items.Item(356) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_358
            Select_Mii.Items.Item(357) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_359
            Select_Mii.Items.Item(358) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_360
            Select_Mii.Items.Item(359) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_361
            Select_Mii.Items.Item(360) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_362
            Select_Mii.Items.Item(361) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_363
            Select_Mii.Items.Item(362) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_364
            Select_Mii.Items.Item(363) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_365
            Select_Mii.Items.Item(364) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_366
            Select_Mii.Items.Item(365) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_367
            Select_Mii.Items.Item(366) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_368
            Select_Mii.Items.Item(367) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_369
            Select_Mii.Items.Item(368) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_370
            Select_Mii.Items.Item(369) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_371
            Select_Mii.Items.Item(370) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_372
            Select_Mii.Items.Item(371) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_373
            Select_Mii.Items.Item(372) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_374
            Select_Mii.Items.Item(373) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_375
            Select_Mii.Items.Item(374) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_376
            Select_Mii.Items.Item(375) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_377
            Select_Mii.Items.Item(376) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_378
            Select_Mii.Items.Item(377) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_379
            Select_Mii.Items.Item(378) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_380
            Select_Mii.Items.Item(379) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_381
            Select_Mii.Items.Item(380) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_382
            Select_Mii.Items.Item(381) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_383
            Select_Mii.Items.Item(382) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_384
            Select_Mii.Items.Item(383) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_385
            Select_Mii.Items.Item(384) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_386
            Select_Mii.Items.Item(385) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_387
            Select_Mii.Items.Item(386) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_388
            Select_Mii.Items.Item(387) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_389
            Select_Mii.Items.Item(388) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_390
            Select_Mii.Items.Item(389) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_391
            Select_Mii.Items.Item(390) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_392
            Select_Mii.Items.Item(391) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_393
            Select_Mii.Items.Item(392) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_394
            Select_Mii.Items.Item(393) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_395
            Select_Mii.Items.Item(394) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_396
            Select_Mii.Items.Item(395) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_397
            Select_Mii.Items.Item(396) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_398
            Select_Mii.Items.Item(397) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_399
            Select_Mii.Items.Item(398) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_400
            Select_Mii.Items.Item(399) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_401
            Select_Mii.Items.Item(400) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_402
            Select_Mii.Items.Item(401) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_403
            Select_Mii.Items.Item(402) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_404
            Select_Mii.Items.Item(403) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_405
            Select_Mii.Items.Item(404) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_406
            Select_Mii.Items.Item(405) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_407
            Select_Mii.Items.Item(406) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_408
            Select_Mii.Items.Item(407) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_409
            Select_Mii.Items.Item(408) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_410
            Select_Mii.Items.Item(409) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_411
            Select_Mii.Items.Item(410) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_412
            Select_Mii.Items.Item(411) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_413
            Select_Mii.Items.Item(412) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_414
            Select_Mii.Items.Item(413) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_415
            Select_Mii.Items.Item(414) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_416
            Select_Mii.Items.Item(415) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_417
            Select_Mii.Items.Item(416) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_418
            Select_Mii.Items.Item(417) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_419
            Select_Mii.Items.Item(418) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_420
            Select_Mii.Items.Item(419) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_421
            Select_Mii.Items.Item(420) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_422
            Select_Mii.Items.Item(421) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_423
            Select_Mii.Items.Item(422) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_424
            Select_Mii.Items.Item(423) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_425
            Select_Mii.Items.Item(424) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_426
            Select_Mii.Items.Item(425) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_427
            Select_Mii.Items.Item(426) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_428
            Select_Mii.Items.Item(427) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_429
            Select_Mii.Items.Item(428) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_430
            Select_Mii.Items.Item(429) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_431
            Select_Mii.Items.Item(430) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_432
            Select_Mii.Items.Item(431) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_433
            Select_Mii.Items.Item(432) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_434
            Select_Mii.Items.Item(433) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_435
            Select_Mii.Items.Item(434) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_436
            Select_Mii.Items.Item(435) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_437
            Select_Mii.Items.Item(436) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_438
            Select_Mii.Items.Item(437) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_439
            Select_Mii.Items.Item(438) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_440
            Select_Mii.Items.Item(439) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_441
            Select_Mii.Items.Item(440) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_442
            Select_Mii.Items.Item(441) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_443
            Select_Mii.Items.Item(442) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_444
            Select_Mii.Items.Item(443) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_445
            Select_Mii.Items.Item(444) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_446
            Select_Mii.Items.Item(445) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_447
            Select_Mii.Items.Item(446) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_448
            Select_Mii.Items.Item(447) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_449
            Select_Mii.Items.Item(448) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_450
            Select_Mii.Items.Item(449) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_451
            Select_Mii.Items.Item(450) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_452
            Select_Mii.Items.Item(451) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_453
            Select_Mii.Items.Item(452) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_454
            Select_Mii.Items.Item(453) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_455
            Select_Mii.Items.Item(454) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_456
            Select_Mii.Items.Item(455) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_457
            Select_Mii.Items.Item(456) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_458
            Select_Mii.Items.Item(457) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_459
            Select_Mii.Items.Item(458) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_460
            Select_Mii.Items.Item(459) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_461
            Select_Mii.Items.Item(460) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_462
            Select_Mii.Items.Item(461) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_463
            Select_Mii.Items.Item(462) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_464
            Select_Mii.Items.Item(463) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_465
            Select_Mii.Items.Item(464) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_466
            Select_Mii.Items.Item(465) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_467
            Select_Mii.Items.Item(466) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_468
            Select_Mii.Items.Item(467) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_469
            Select_Mii.Items.Item(468) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_470
            Select_Mii.Items.Item(469) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_471
            Select_Mii.Items.Item(470) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_472
            Select_Mii.Items.Item(471) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_473
            Select_Mii.Items.Item(472) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_474
            Select_Mii.Items.Item(473) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_475
            Select_Mii.Items.Item(474) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_476
            Select_Mii.Items.Item(475) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_477
            Select_Mii.Items.Item(476) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_478
            Select_Mii.Items.Item(477) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_479
            Select_Mii.Items.Item(478) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_480
            Select_Mii.Items.Item(479) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_481
            Select_Mii.Items.Item(480) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_482
            Select_Mii.Items.Item(481) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_483
            Select_Mii.Items.Item(482) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_484
            Select_Mii.Items.Item(483) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_485
            Select_Mii.Items.Item(484) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_486
            Select_Mii.Items.Item(485) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_487
            Select_Mii.Items.Item(486) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_488
            Select_Mii.Items.Item(487) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_489
            Select_Mii.Items.Item(488) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_490
            Select_Mii.Items.Item(489) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_491
            Select_Mii.Items.Item(490) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_492
            Select_Mii.Items.Item(491) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_493
            Select_Mii.Items.Item(492) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_494
            Select_Mii.Items.Item(493) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_495
            Select_Mii.Items.Item(494) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_496
            Select_Mii.Items.Item(495) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_497
            Select_Mii.Items.Item(496) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_498
            Select_Mii.Items.Item(497) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_499
            Select_Mii.Items.Item(498) = ReadMiiname.ReadUnicodeString(10)
            ReadMiiname.Position = Mii_name_500
            Select_Mii.Items.Item(499) = ReadMiiname.ReadUnicodeString(10)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Select_Mii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Mii.SelectedIndexChanged
        ReadMiiappareance()
        Text_Miiname.Text = Select_Mii.SelectedItem
    End Sub

    Public Sub ReadMiiappareance()
        Try
            Dim ReadMiiapp As New PackageIO.Reader(CStr(mainsav), PackageIO.Endian.Little)
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                ReadMiiapp.Position = Mii_appareance_1
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                ReadMiiapp.Position = Mii_appareance_2
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                ReadMiiapp.Position = Mii_appareance_3
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                ReadMiiapp.Position = Mii_appareance_4
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                ReadMiiapp.Position = Mii_appareance_5
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                ReadMiiapp.Position = Mii_appareance_6
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                ReadMiiapp.Position = Mii_appareance_7
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                ReadMiiapp.Position = Mii_appareance_8
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                ReadMiiapp.Position = Mii_appareance_9
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                ReadMiiapp.Position = Mii_appareance_10
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                ReadMiiapp.Position = Mii_appareance_11
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                ReadMiiapp.Position = Mii_appareance_12
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                ReadMiiapp.Position = Mii_appareance_13
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                ReadMiiapp.Position = Mii_appareance_14
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                ReadMiiapp.Position = Mii_appareance_15
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                ReadMiiapp.Position = Mii_appareance_16
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                ReadMiiapp.Position = Mii_appareance_17
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                ReadMiiapp.Position = Mii_appareance_18
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                ReadMiiapp.Position = Mii_appareance_19
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                ReadMiiapp.Position = Mii_appareance_20
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                ReadMiiapp.Position = Mii_appareance_21
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                ReadMiiapp.Position = Mii_appareance_22
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                ReadMiiapp.Position = Mii_appareance_23
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                ReadMiiapp.Position = Mii_appareance_24
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                ReadMiiapp.Position = Mii_appareance_25
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                ReadMiiapp.Position = Mii_appareance_26
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                ReadMiiapp.Position = Mii_appareance_27
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                ReadMiiapp.Position = Mii_appareance_28
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                ReadMiiapp.Position = Mii_appareance_29
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                ReadMiiapp.Position = Mii_appareance_30
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                ReadMiiapp.Position = Mii_appareance_31
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                ReadMiiapp.Position = Mii_appareance_32
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                ReadMiiapp.Position = Mii_appareance_33
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                ReadMiiapp.Position = Mii_appareance_34
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                ReadMiiapp.Position = Mii_appareance_35
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                ReadMiiapp.Position = Mii_appareance_36
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                ReadMiiapp.Position = Mii_appareance_37
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                ReadMiiapp.Position = Mii_appareance_38
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                ReadMiiapp.Position = Mii_appareance_39
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                ReadMiiapp.Position = Mii_appareance_40
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                ReadMiiapp.Position = Mii_appareance_41
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                ReadMiiapp.Position = Mii_appareance_42
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                ReadMiiapp.Position = Mii_appareance_43
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                ReadMiiapp.Position = Mii_appareance_44
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                ReadMiiapp.Position = Mii_appareance_45
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                ReadMiiapp.Position = Mii_appareance_46
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                ReadMiiapp.Position = Mii_appareance_47
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                ReadMiiapp.Position = Mii_appareance_48
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                ReadMiiapp.Position = Mii_appareance_49
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                ReadMiiapp.Position = Mii_appareance_50
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                ReadMiiapp.Position = Mii_appareance_51
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                ReadMiiapp.Position = Mii_appareance_52
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                ReadMiiapp.Position = Mii_appareance_53
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                ReadMiiapp.Position = Mii_appareance_54
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                ReadMiiapp.Position = Mii_appareance_55
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                ReadMiiapp.Position = Mii_appareance_56
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                ReadMiiapp.Position = Mii_appareance_57
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                ReadMiiapp.Position = Mii_appareance_58
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                ReadMiiapp.Position = Mii_appareance_59
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                ReadMiiapp.Position = Mii_appareance_60
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                ReadMiiapp.Position = Mii_appareance_61
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                ReadMiiapp.Position = Mii_appareance_62
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                ReadMiiapp.Position = Mii_appareance_63
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                ReadMiiapp.Position = Mii_appareance_64
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                ReadMiiapp.Position = Mii_appareance_65
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                ReadMiiapp.Position = Mii_appareance_66
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                ReadMiiapp.Position = Mii_appareance_67
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                ReadMiiapp.Position = Mii_appareance_68
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                ReadMiiapp.Position = Mii_appareance_69
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                ReadMiiapp.Position = Mii_appareance_70
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                ReadMiiapp.Position = Mii_appareance_71
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                ReadMiiapp.Position = Mii_appareance_72
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                ReadMiiapp.Position = Mii_appareance_73
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                ReadMiiapp.Position = Mii_appareance_74
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                ReadMiiapp.Position = Mii_appareance_75
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                ReadMiiapp.Position = Mii_appareance_76
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                ReadMiiapp.Position = Mii_appareance_77
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                ReadMiiapp.Position = Mii_appareance_78
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                ReadMiiapp.Position = Mii_appareance_79
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                ReadMiiapp.Position = Mii_appareance_80
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                ReadMiiapp.Position = Mii_appareance_81
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                ReadMiiapp.Position = Mii_appareance_82
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                ReadMiiapp.Position = Mii_appareance_83
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                ReadMiiapp.Position = Mii_appareance_84
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                ReadMiiapp.Position = Mii_appareance_85
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                ReadMiiapp.Position = Mii_appareance_86
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                ReadMiiapp.Position = Mii_appareance_87
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                ReadMiiapp.Position = Mii_appareance_88
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                ReadMiiapp.Position = Mii_appareance_89
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                ReadMiiapp.Position = Mii_appareance_90
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                ReadMiiapp.Position = Mii_appareance_91
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                ReadMiiapp.Position = Mii_appareance_92
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                ReadMiiapp.Position = Mii_appareance_93
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                ReadMiiapp.Position = Mii_appareance_94
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                ReadMiiapp.Position = Mii_appareance_95
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                ReadMiiapp.Position = Mii_appareance_96
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                ReadMiiapp.Position = Mii_appareance_97
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                ReadMiiapp.Position = Mii_appareance_98
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                ReadMiiapp.Position = Mii_appareance_99
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                ReadMiiapp.Position = Mii_appareance_100
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(100) Then
                ReadMiiapp.Position = Mii_appareance_101
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(101) Then
                ReadMiiapp.Position = Mii_appareance_102
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(102) Then
                ReadMiiapp.Position = Mii_appareance_103
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(103) Then
                ReadMiiapp.Position = Mii_appareance_104
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(104) Then
                ReadMiiapp.Position = Mii_appareance_105
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(105) Then
                ReadMiiapp.Position = Mii_appareance_106
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(106) Then
                ReadMiiapp.Position = Mii_appareance_107
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(107) Then
                ReadMiiapp.Position = Mii_appareance_108
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(108) Then
                ReadMiiapp.Position = Mii_appareance_109
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(109) Then
                ReadMiiapp.Position = Mii_appareance_110
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(110) Then
                ReadMiiapp.Position = Mii_appareance_111
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(111) Then
                ReadMiiapp.Position = Mii_appareance_112
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(112) Then
                ReadMiiapp.Position = Mii_appareance_113
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(113) Then
                ReadMiiapp.Position = Mii_appareance_114
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(114) Then
                ReadMiiapp.Position = Mii_appareance_115
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(115) Then
                ReadMiiapp.Position = Mii_appareance_116
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(116) Then
                ReadMiiapp.Position = Mii_appareance_117
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(117) Then
                ReadMiiapp.Position = Mii_appareance_118
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(118) Then
                ReadMiiapp.Position = Mii_appareance_119
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(119) Then
                ReadMiiapp.Position = Mii_appareance_120
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(120) Then
                ReadMiiapp.Position = Mii_appareance_121
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(121) Then
                ReadMiiapp.Position = Mii_appareance_122
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(122) Then
                ReadMiiapp.Position = Mii_appareance_123
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(123) Then
                ReadMiiapp.Position = Mii_appareance_124
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(124) Then
                ReadMiiapp.Position = Mii_appareance_125
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(125) Then
                ReadMiiapp.Position = Mii_appareance_126
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(126) Then
                ReadMiiapp.Position = Mii_appareance_127
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(127) Then
                ReadMiiapp.Position = Mii_appareance_128
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(128) Then
                ReadMiiapp.Position = Mii_appareance_129
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(129) Then
                ReadMiiapp.Position = Mii_appareance_130
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(130) Then
                ReadMiiapp.Position = Mii_appareance_131
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(131) Then
                ReadMiiapp.Position = Mii_appareance_132
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(132) Then
                ReadMiiapp.Position = Mii_appareance_133
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(133) Then
                ReadMiiapp.Position = Mii_appareance_134
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(134) Then
                ReadMiiapp.Position = Mii_appareance_135
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(135) Then
                ReadMiiapp.Position = Mii_appareance_136
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(136) Then
                ReadMiiapp.Position = Mii_appareance_137
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(137) Then
                ReadMiiapp.Position = Mii_appareance_138
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(138) Then
                ReadMiiapp.Position = Mii_appareance_139
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(139) Then
                ReadMiiapp.Position = Mii_appareance_140
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(140) Then
                ReadMiiapp.Position = Mii_appareance_141
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(141) Then
                ReadMiiapp.Position = Mii_appareance_142
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(142) Then
                ReadMiiapp.Position = Mii_appareance_143
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(143) Then
                ReadMiiapp.Position = Mii_appareance_144
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(144) Then
                ReadMiiapp.Position = Mii_appareance_145
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(145) Then
                ReadMiiapp.Position = Mii_appareance_146
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(146) Then
                ReadMiiapp.Position = Mii_appareance_147
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(147) Then
                ReadMiiapp.Position = Mii_appareance_148
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(148) Then
                ReadMiiapp.Position = Mii_appareance_149
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(149) Then
                ReadMiiapp.Position = Mii_appareance_150
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(150) Then
                ReadMiiapp.Position = Mii_appareance_151
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(151) Then
                ReadMiiapp.Position = Mii_appareance_152
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(152) Then
                ReadMiiapp.Position = Mii_appareance_153
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(153) Then
                ReadMiiapp.Position = Mii_appareance_154
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(154) Then
                ReadMiiapp.Position = Mii_appareance_155
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(155) Then
                ReadMiiapp.Position = Mii_appareance_156
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(156) Then
                ReadMiiapp.Position = Mii_appareance_157
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(157) Then
                ReadMiiapp.Position = Mii_appareance_158
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(158) Then
                ReadMiiapp.Position = Mii_appareance_159
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(159) Then
                ReadMiiapp.Position = Mii_appareance_160
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(160) Then
                ReadMiiapp.Position = Mii_appareance_161
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(161) Then
                ReadMiiapp.Position = Mii_appareance_162
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(162) Then
                ReadMiiapp.Position = Mii_appareance_163
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(163) Then
                ReadMiiapp.Position = Mii_appareance_164
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(164) Then
                ReadMiiapp.Position = Mii_appareance_165
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(165) Then
                ReadMiiapp.Position = Mii_appareance_166
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(166) Then
                ReadMiiapp.Position = Mii_appareance_167
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(167) Then
                ReadMiiapp.Position = Mii_appareance_168
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(168) Then
                ReadMiiapp.Position = Mii_appareance_169
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(169) Then
                ReadMiiapp.Position = Mii_appareance_170
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(170) Then
                ReadMiiapp.Position = Mii_appareance_171
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(171) Then
                ReadMiiapp.Position = Mii_appareance_172
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(172) Then
                ReadMiiapp.Position = Mii_appareance_173
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(173) Then
                ReadMiiapp.Position = Mii_appareance_174
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(174) Then
                ReadMiiapp.Position = Mii_appareance_175
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(175) Then
                ReadMiiapp.Position = Mii_appareance_176
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(176) Then
                ReadMiiapp.Position = Mii_appareance_177
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(177) Then
                ReadMiiapp.Position = Mii_appareance_178
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(178) Then
                ReadMiiapp.Position = Mii_appareance_179
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(179) Then
                ReadMiiapp.Position = Mii_appareance_180
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(180) Then
                ReadMiiapp.Position = Mii_appareance_181
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(181) Then
                ReadMiiapp.Position = Mii_appareance_182
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(182) Then
                ReadMiiapp.Position = Mii_appareance_183
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(183) Then
                ReadMiiapp.Position = Mii_appareance_184
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(184) Then
                ReadMiiapp.Position = Mii_appareance_185
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(185) Then
                ReadMiiapp.Position = Mii_appareance_186
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(186) Then
                ReadMiiapp.Position = Mii_appareance_187
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(187) Then
                ReadMiiapp.Position = Mii_appareance_188
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(188) Then
                ReadMiiapp.Position = Mii_appareance_189
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(189) Then
                ReadMiiapp.Position = Mii_appareance_190
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(190) Then
                ReadMiiapp.Position = Mii_appareance_191
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(191) Then
                ReadMiiapp.Position = Mii_appareance_192
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(192) Then
                ReadMiiapp.Position = Mii_appareance_193
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(193) Then
                ReadMiiapp.Position = Mii_appareance_194
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(194) Then
                ReadMiiapp.Position = Mii_appareance_195
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(195) Then
                ReadMiiapp.Position = Mii_appareance_196
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(196) Then
                ReadMiiapp.Position = Mii_appareance_197
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(197) Then
                ReadMiiapp.Position = Mii_appareance_198
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(198) Then
                ReadMiiapp.Position = Mii_appareance_199
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(199) Then
                ReadMiiapp.Position = Mii_appareance_200
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(200) Then
                ReadMiiapp.Position = Mii_appareance_201
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(201) Then
                ReadMiiapp.Position = Mii_appareance_202
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(202) Then
                ReadMiiapp.Position = Mii_appareance_203
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(203) Then
                ReadMiiapp.Position = Mii_appareance_204
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(204) Then
                ReadMiiapp.Position = Mii_appareance_205
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(205) Then
                ReadMiiapp.Position = Mii_appareance_206
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(206) Then
                ReadMiiapp.Position = Mii_appareance_207
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(207) Then
                ReadMiiapp.Position = Mii_appareance_208
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(208) Then
                ReadMiiapp.Position = Mii_appareance_209
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(209) Then
                ReadMiiapp.Position = Mii_appareance_210
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(210) Then
                ReadMiiapp.Position = Mii_appareance_211
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(211) Then
                ReadMiiapp.Position = Mii_appareance_212
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(212) Then
                ReadMiiapp.Position = Mii_appareance_213
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(213) Then
                ReadMiiapp.Position = Mii_appareance_214
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(214) Then
                ReadMiiapp.Position = Mii_appareance_215
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(215) Then
                ReadMiiapp.Position = Mii_appareance_216
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(216) Then
                ReadMiiapp.Position = Mii_appareance_217
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(217) Then
                ReadMiiapp.Position = Mii_appareance_218
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(218) Then
                ReadMiiapp.Position = Mii_appareance_219
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(219) Then
                ReadMiiapp.Position = Mii_appareance_220
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(220) Then
                ReadMiiapp.Position = Mii_appareance_221
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(221) Then
                ReadMiiapp.Position = Mii_appareance_222
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(222) Then
                ReadMiiapp.Position = Mii_appareance_223
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(223) Then
                ReadMiiapp.Position = Mii_appareance_224
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(224) Then
                ReadMiiapp.Position = Mii_appareance_225
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(225) Then
                ReadMiiapp.Position = Mii_appareance_226
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(226) Then
                ReadMiiapp.Position = Mii_appareance_227
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(227) Then
                ReadMiiapp.Position = Mii_appareance_228
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(228) Then
                ReadMiiapp.Position = Mii_appareance_229
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(229) Then
                ReadMiiapp.Position = Mii_appareance_230
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(230) Then
                ReadMiiapp.Position = Mii_appareance_231
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(231) Then
                ReadMiiapp.Position = Mii_appareance_232
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(232) Then
                ReadMiiapp.Position = Mii_appareance_233
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(233) Then
                ReadMiiapp.Position = Mii_appareance_234
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(234) Then
                ReadMiiapp.Position = Mii_appareance_235
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(235) Then
                ReadMiiapp.Position = Mii_appareance_236
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(236) Then
                ReadMiiapp.Position = Mii_appareance_237
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(237) Then
                ReadMiiapp.Position = Mii_appareance_238
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(238) Then
                ReadMiiapp.Position = Mii_appareance_239
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(239) Then
                ReadMiiapp.Position = Mii_appareance_240
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(240) Then
                ReadMiiapp.Position = Mii_appareance_241
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(241) Then
                ReadMiiapp.Position = Mii_appareance_242
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(242) Then
                ReadMiiapp.Position = Mii_appareance_243
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(243) Then
                ReadMiiapp.Position = Mii_appareance_244
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(244) Then
                ReadMiiapp.Position = Mii_appareance_245
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(245) Then
                ReadMiiapp.Position = Mii_appareance_246
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(246) Then
                ReadMiiapp.Position = Mii_appareance_247
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(247) Then
                ReadMiiapp.Position = Mii_appareance_248
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(248) Then
                ReadMiiapp.Position = Mii_appareance_249
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(249) Then
                ReadMiiapp.Position = Mii_appareance_250
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(250) Then
                ReadMiiapp.Position = Mii_appareance_251
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(251) Then
                ReadMiiapp.Position = Mii_appareance_252
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(252) Then
                ReadMiiapp.Position = Mii_appareance_253
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(253) Then
                ReadMiiapp.Position = Mii_appareance_254
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(254) Then
                ReadMiiapp.Position = Mii_appareance_255
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(255) Then
                ReadMiiapp.Position = Mii_appareance_256
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(256) Then
                ReadMiiapp.Position = Mii_appareance_257
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(257) Then
                ReadMiiapp.Position = Mii_appareance_258
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(258) Then
                ReadMiiapp.Position = Mii_appareance_259
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(259) Then
                ReadMiiapp.Position = Mii_appareance_260
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(260) Then
                ReadMiiapp.Position = Mii_appareance_261
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(261) Then
                ReadMiiapp.Position = Mii_appareance_262
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(262) Then
                ReadMiiapp.Position = Mii_appareance_263
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(263) Then
                ReadMiiapp.Position = Mii_appareance_264
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(264) Then
                ReadMiiapp.Position = Mii_appareance_265
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(265) Then
                ReadMiiapp.Position = Mii_appareance_266
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(266) Then
                ReadMiiapp.Position = Mii_appareance_267
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(267) Then
                ReadMiiapp.Position = Mii_appareance_268
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(268) Then
                ReadMiiapp.Position = Mii_appareance_269
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(269) Then
                ReadMiiapp.Position = Mii_appareance_270
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(270) Then
                ReadMiiapp.Position = Mii_appareance_271
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(271) Then
                ReadMiiapp.Position = Mii_appareance_272
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(272) Then
                ReadMiiapp.Position = Mii_appareance_273
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(273) Then
                ReadMiiapp.Position = Mii_appareance_274
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(274) Then
                ReadMiiapp.Position = Mii_appareance_275
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(275) Then
                ReadMiiapp.Position = Mii_appareance_276
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(276) Then
                ReadMiiapp.Position = Mii_appareance_277
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(277) Then
                ReadMiiapp.Position = Mii_appareance_278
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(278) Then
                ReadMiiapp.Position = Mii_appareance_279
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(279) Then
                ReadMiiapp.Position = Mii_appareance_280
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(280) Then
                ReadMiiapp.Position = Mii_appareance_281
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(281) Then
                ReadMiiapp.Position = Mii_appareance_282
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(282) Then
                ReadMiiapp.Position = Mii_appareance_283
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(283) Then
                ReadMiiapp.Position = Mii_appareance_284
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(284) Then
                ReadMiiapp.Position = Mii_appareance_285
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(285) Then
                ReadMiiapp.Position = Mii_appareance_286
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(286) Then
                ReadMiiapp.Position = Mii_appareance_287
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(287) Then
                ReadMiiapp.Position = Mii_appareance_288
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(288) Then
                ReadMiiapp.Position = Mii_appareance_289
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(289) Then
                ReadMiiapp.Position = Mii_appareance_290
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(290) Then
                ReadMiiapp.Position = Mii_appareance_291
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(291) Then
                ReadMiiapp.Position = Mii_appareance_292
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(292) Then
                ReadMiiapp.Position = Mii_appareance_293
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(293) Then
                ReadMiiapp.Position = Mii_appareance_294
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(294) Then
                ReadMiiapp.Position = Mii_appareance_295
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(295) Then
                ReadMiiapp.Position = Mii_appareance_296
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(296) Then
                ReadMiiapp.Position = Mii_appareance_297
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(297) Then
                ReadMiiapp.Position = Mii_appareance_298
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(298) Then
                ReadMiiapp.Position = Mii_appareance_299
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(299) Then
                ReadMiiapp.Position = Mii_appareance_300
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(300) Then
                ReadMiiapp.Position = Mii_appareance_301
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(301) Then
                ReadMiiapp.Position = Mii_appareance_302
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(302) Then
                ReadMiiapp.Position = Mii_appareance_303
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(303) Then
                ReadMiiapp.Position = Mii_appareance_304
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(304) Then
                ReadMiiapp.Position = Mii_appareance_305
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(305) Then
                ReadMiiapp.Position = Mii_appareance_306
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(306) Then
                ReadMiiapp.Position = Mii_appareance_307
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(307) Then
                ReadMiiapp.Position = Mii_appareance_308
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(308) Then
                ReadMiiapp.Position = Mii_appareance_309
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(309) Then
                ReadMiiapp.Position = Mii_appareance_310
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(310) Then
                ReadMiiapp.Position = Mii_appareance_311
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(311) Then
                ReadMiiapp.Position = Mii_appareance_312
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(312) Then
                ReadMiiapp.Position = Mii_appareance_313
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(313) Then
                ReadMiiapp.Position = Mii_appareance_314
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(314) Then
                ReadMiiapp.Position = Mii_appareance_315
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(315) Then
                ReadMiiapp.Position = Mii_appareance_316
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(316) Then
                ReadMiiapp.Position = Mii_appareance_317
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(317) Then
                ReadMiiapp.Position = Mii_appareance_318
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(318) Then
                ReadMiiapp.Position = Mii_appareance_319
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(319) Then
                ReadMiiapp.Position = Mii_appareance_320
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(320) Then
                ReadMiiapp.Position = Mii_appareance_321
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(321) Then
                ReadMiiapp.Position = Mii_appareance_322
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(322) Then
                ReadMiiapp.Position = Mii_appareance_323
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(323) Then
                ReadMiiapp.Position = Mii_appareance_324
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(324) Then
                ReadMiiapp.Position = Mii_appareance_325
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(325) Then
                ReadMiiapp.Position = Mii_appareance_326
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(326) Then
                ReadMiiapp.Position = Mii_appareance_327
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(327) Then
                ReadMiiapp.Position = Mii_appareance_328
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(328) Then
                ReadMiiapp.Position = Mii_appareance_329
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(329) Then
                ReadMiiapp.Position = Mii_appareance_330
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(330) Then
                ReadMiiapp.Position = Mii_appareance_331
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(331) Then
                ReadMiiapp.Position = Mii_appareance_332
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(332) Then
                ReadMiiapp.Position = Mii_appareance_333
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(333) Then
                ReadMiiapp.Position = Mii_appareance_334
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(334) Then
                ReadMiiapp.Position = Mii_appareance_335
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(335) Then
                ReadMiiapp.Position = Mii_appareance_336
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(336) Then
                ReadMiiapp.Position = Mii_appareance_337
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(337) Then
                ReadMiiapp.Position = Mii_appareance_338
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(338) Then
                ReadMiiapp.Position = Mii_appareance_339
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(339) Then
                ReadMiiapp.Position = Mii_appareance_340
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(340) Then
                ReadMiiapp.Position = Mii_appareance_341
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(341) Then
                ReadMiiapp.Position = Mii_appareance_342
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(342) Then
                ReadMiiapp.Position = Mii_appareance_343
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(343) Then
                ReadMiiapp.Position = Mii_appareance_344
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(344) Then
                ReadMiiapp.Position = Mii_appareance_345
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(345) Then
                ReadMiiapp.Position = Mii_appareance_346
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(346) Then
                ReadMiiapp.Position = Mii_appareance_347
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(347) Then
                ReadMiiapp.Position = Mii_appareance_348
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(348) Then
                ReadMiiapp.Position = Mii_appareance_349
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(349) Then
                ReadMiiapp.Position = Mii_appareance_350
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(350) Then
                ReadMiiapp.Position = Mii_appareance_351
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(351) Then
                ReadMiiapp.Position = Mii_appareance_352
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(352) Then
                ReadMiiapp.Position = Mii_appareance_353
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(353) Then
                ReadMiiapp.Position = Mii_appareance_354
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(354) Then
                ReadMiiapp.Position = Mii_appareance_355
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(355) Then
                ReadMiiapp.Position = Mii_appareance_356
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(356) Then
                ReadMiiapp.Position = Mii_appareance_357
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(357) Then
                ReadMiiapp.Position = Mii_appareance_358
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(358) Then
                ReadMiiapp.Position = Mii_appareance_359
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(359) Then
                ReadMiiapp.Position = Mii_appareance_360
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(360) Then
                ReadMiiapp.Position = Mii_appareance_361
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(361) Then
                ReadMiiapp.Position = Mii_appareance_362
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(362) Then
                ReadMiiapp.Position = Mii_appareance_363
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(363) Then
                ReadMiiapp.Position = Mii_appareance_364
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(364) Then
                ReadMiiapp.Position = Mii_appareance_365
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(365) Then
                ReadMiiapp.Position = Mii_appareance_366
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(366) Then
                ReadMiiapp.Position = Mii_appareance_367
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(367) Then
                ReadMiiapp.Position = Mii_appareance_368
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(368) Then
                ReadMiiapp.Position = Mii_appareance_369
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(369) Then
                ReadMiiapp.Position = Mii_appareance_370
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(370) Then
                ReadMiiapp.Position = Mii_appareance_371
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(371) Then
                ReadMiiapp.Position = Mii_appareance_372
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(372) Then
                ReadMiiapp.Position = Mii_appareance_373
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(373) Then
                ReadMiiapp.Position = Mii_appareance_374
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(374) Then
                ReadMiiapp.Position = Mii_appareance_375
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(375) Then
                ReadMiiapp.Position = Mii_appareance_376
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(376) Then
                ReadMiiapp.Position = Mii_appareance_377
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(377) Then
                ReadMiiapp.Position = Mii_appareance_378
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(378) Then
                ReadMiiapp.Position = Mii_appareance_379
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(379) Then
                ReadMiiapp.Position = Mii_appareance_380
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(380) Then
                ReadMiiapp.Position = Mii_appareance_381
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(381) Then
                ReadMiiapp.Position = Mii_appareance_382
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(382) Then
                ReadMiiapp.Position = Mii_appareance_383
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(383) Then
                ReadMiiapp.Position = Mii_appareance_384
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(384) Then
                ReadMiiapp.Position = Mii_appareance_385
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(385) Then
                ReadMiiapp.Position = Mii_appareance_386
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(386) Then
                ReadMiiapp.Position = Mii_appareance_387
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(387) Then
                ReadMiiapp.Position = Mii_appareance_388
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(388) Then
                ReadMiiapp.Position = Mii_appareance_389
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(389) Then
                ReadMiiapp.Position = Mii_appareance_390
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(390) Then
                ReadMiiapp.Position = Mii_appareance_391
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(391) Then
                ReadMiiapp.Position = Mii_appareance_392
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(392) Then
                ReadMiiapp.Position = Mii_appareance_393
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(393) Then
                ReadMiiapp.Position = Mii_appareance_394
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(394) Then
                ReadMiiapp.Position = Mii_appareance_395
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(395) Then
                ReadMiiapp.Position = Mii_appareance_396
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(396) Then
                ReadMiiapp.Position = Mii_appareance_397
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(397) Then
                ReadMiiapp.Position = Mii_appareance_398
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(398) Then
                ReadMiiapp.Position = Mii_appareance_399
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(399) Then
                ReadMiiapp.Position = Mii_appareance_400
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(400) Then
                ReadMiiapp.Position = Mii_appareance_401
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(401) Then
                ReadMiiapp.Position = Mii_appareance_402
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(402) Then
                ReadMiiapp.Position = Mii_appareance_403
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(403) Then
                ReadMiiapp.Position = Mii_appareance_404
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(404) Then
                ReadMiiapp.Position = Mii_appareance_405
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(405) Then
                ReadMiiapp.Position = Mii_appareance_406
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(406) Then
                ReadMiiapp.Position = Mii_appareance_407
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(407) Then
                ReadMiiapp.Position = Mii_appareance_408
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(408) Then
                ReadMiiapp.Position = Mii_appareance_409
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(409) Then
                ReadMiiapp.Position = Mii_appareance_410
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(410) Then
                ReadMiiapp.Position = Mii_appareance_411
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(411) Then
                ReadMiiapp.Position = Mii_appareance_412
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(412) Then
                ReadMiiapp.Position = Mii_appareance_413
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(413) Then
                ReadMiiapp.Position = Mii_appareance_414
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(414) Then
                ReadMiiapp.Position = Mii_appareance_415
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(415) Then
                ReadMiiapp.Position = Mii_appareance_416
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(416) Then
                ReadMiiapp.Position = Mii_appareance_417
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(417) Then
                ReadMiiapp.Position = Mii_appareance_418
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(418) Then
                ReadMiiapp.Position = Mii_appareance_419
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(419) Then
                ReadMiiapp.Position = Mii_appareance_420
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(420) Then
                ReadMiiapp.Position = Mii_appareance_421
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(421) Then
                ReadMiiapp.Position = Mii_appareance_422
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(422) Then
                ReadMiiapp.Position = Mii_appareance_423
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(423) Then
                ReadMiiapp.Position = Mii_appareance_424
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(424) Then
                ReadMiiapp.Position = Mii_appareance_425
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(425) Then
                ReadMiiapp.Position = Mii_appareance_426
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(426) Then
                ReadMiiapp.Position = Mii_appareance_427
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(427) Then
                ReadMiiapp.Position = Mii_appareance_428
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(428) Then
                ReadMiiapp.Position = Mii_appareance_429
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(429) Then
                ReadMiiapp.Position = Mii_appareance_430
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(430) Then
                ReadMiiapp.Position = Mii_appareance_431
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(431) Then
                ReadMiiapp.Position = Mii_appareance_432
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(432) Then
                ReadMiiapp.Position = Mii_appareance_433
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(433) Then
                ReadMiiapp.Position = Mii_appareance_434
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(434) Then
                ReadMiiapp.Position = Mii_appareance_435
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(435) Then
                ReadMiiapp.Position = Mii_appareance_436
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(436) Then
                ReadMiiapp.Position = Mii_appareance_437
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(437) Then
                ReadMiiapp.Position = Mii_appareance_438
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(438) Then
                ReadMiiapp.Position = Mii_appareance_439
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(439) Then
                ReadMiiapp.Position = Mii_appareance_440
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(440) Then
                ReadMiiapp.Position = Mii_appareance_441
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(441) Then
                ReadMiiapp.Position = Mii_appareance_442
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(442) Then
                ReadMiiapp.Position = Mii_appareance_443
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(443) Then
                ReadMiiapp.Position = Mii_appareance_444
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(444) Then
                ReadMiiapp.Position = Mii_appareance_445
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(445) Then
                ReadMiiapp.Position = Mii_appareance_446
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(446) Then
                ReadMiiapp.Position = Mii_appareance_447
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(447) Then
                ReadMiiapp.Position = Mii_appareance_448
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(448) Then
                ReadMiiapp.Position = Mii_appareance_449
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(449) Then
                ReadMiiapp.Position = Mii_appareance_450
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(450) Then
                ReadMiiapp.Position = Mii_appareance_451
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(451) Then
                ReadMiiapp.Position = Mii_appareance_452
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(452) Then
                ReadMiiapp.Position = Mii_appareance_453
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(453) Then
                ReadMiiapp.Position = Mii_appareance_454
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(454) Then
                ReadMiiapp.Position = Mii_appareance_455
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(455) Then
                ReadMiiapp.Position = Mii_appareance_456
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(456) Then
                ReadMiiapp.Position = Mii_appareance_457
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(457) Then
                ReadMiiapp.Position = Mii_appareance_458
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(458) Then
                ReadMiiapp.Position = Mii_appareance_459
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(459) Then
                ReadMiiapp.Position = Mii_appareance_460
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(460) Then
                ReadMiiapp.Position = Mii_appareance_461
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(461) Then
                ReadMiiapp.Position = Mii_appareance_462
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(462) Then
                ReadMiiapp.Position = Mii_appareance_463
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(463) Then
                ReadMiiapp.Position = Mii_appareance_464
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(464) Then
                ReadMiiapp.Position = Mii_appareance_465
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(465) Then
                ReadMiiapp.Position = Mii_appareance_466
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(466) Then
                ReadMiiapp.Position = Mii_appareance_467
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(467) Then
                ReadMiiapp.Position = Mii_appareance_468
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(468) Then
                ReadMiiapp.Position = Mii_appareance_469
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(469) Then
                ReadMiiapp.Position = Mii_appareance_470
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(470) Then
                ReadMiiapp.Position = Mii_appareance_471
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(471) Then
                ReadMiiapp.Position = Mii_appareance_472
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(472) Then
                ReadMiiapp.Position = Mii_appareance_473
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(473) Then
                ReadMiiapp.Position = Mii_appareance_474
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(474) Then
                ReadMiiapp.Position = Mii_appareance_475
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(475) Then
                ReadMiiapp.Position = Mii_appareance_476
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(476) Then
                ReadMiiapp.Position = Mii_appareance_477
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(477) Then
                ReadMiiapp.Position = Mii_appareance_478
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(478) Then
                ReadMiiapp.Position = Mii_appareance_479
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(479) Then
                ReadMiiapp.Position = Mii_appareance_480
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(480) Then
                ReadMiiapp.Position = Mii_appareance_481
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(481) Then
                ReadMiiapp.Position = Mii_appareance_482
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(482) Then
                ReadMiiapp.Position = Mii_appareance_483
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(483) Then
                ReadMiiapp.Position = Mii_appareance_484
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(484) Then
                ReadMiiapp.Position = Mii_appareance_485
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(485) Then
                ReadMiiapp.Position = Mii_appareance_486
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(486) Then
                ReadMiiapp.Position = Mii_appareance_487
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(487) Then
                ReadMiiapp.Position = Mii_appareance_488
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(488) Then
                ReadMiiapp.Position = Mii_appareance_489
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(489) Then
                ReadMiiapp.Position = Mii_appareance_490
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(490) Then
                ReadMiiapp.Position = Mii_appareance_491
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(491) Then
                ReadMiiapp.Position = Mii_appareance_492
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(492) Then
                ReadMiiapp.Position = Mii_appareance_493
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(493) Then
                ReadMiiapp.Position = Mii_appareance_494
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(494) Then
                ReadMiiapp.Position = Mii_appareance_495
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(495) Then
                ReadMiiapp.Position = Mii_appareance_496
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(496) Then
                ReadMiiapp.Position = Mii_appareance_497
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(497) Then
                ReadMiiapp.Position = Mii_appareance_498
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(498) Then
                ReadMiiapp.Position = Mii_appareance_499
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
            If Select_Mii.SelectedItem = Select_Mii.Items.Item(499) Then
                ReadMiiapp.Position = Mii_appareance_500
                Text_Mii_appareanceE.Text = ReadMiiapp.ReadHexString(&H7C8)
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to read main.sav Mii appareance" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_Click(sender As Object, e As EventArgs) Handles Icon_extract.Click
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Filter = "Miitopia Mii|*.MiitopiaMiA"
            SaveFileDialog1.FileName = "Miiappareance_" & Today.Year & "_" & Today.Month & "_" & Today.Day & "_" & TimeOfDay.Hour & "h" & TimeOfDay.Minute
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Writer1 As New System.IO.StreamWriter(SaveFileDialog1.FileName)
                Writer1.Close()
                Dim Writer As New PackageIO.Writer(SaveFileDialog1.FileName, PackageIO.Endian.Little)
                Writer.WriteHexString(Text_Mii_appareanceE.Text)
                MSE_dialog.text_dialog.Text = "Mii appareance has been successfully extracted"
                MSE_dialog.ShowDialog()
            End If
        Catch ex As Exception
            MSE_dialog.text_dialog.Text = "Failed to extract Mii appareance" & vbNewLine & "Report this issue or retry"
            MSE_dialog.ShowDialog()
        End Try
    End Sub

    Private Sub Icon_extract_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_extract.MouseMove
        Text_description.Text = "Click to export your Mii appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_extract_MouseLeave(sender As Object, e As EventArgs) Handles Icon_extract.MouseLeave
        Panel_description.Visible = False
    End Sub

    Private Sub Icon_import_Click(sender As Object, e As EventArgs) Handles Icon_import.Click
        Dim open As New OpenFileDialog

        MSE_dialog.text_dialog.Text = "Open a Miitopia Mii appareance file" & vbNewLine & "Current Mii appareance will be replace by Mii appareance in Miitopia Mii appareance file" & vbNewLine & vbNewLine & "Do you want to continue ?"
        MSE_dialog.MSE_dialog_panelbuttons.Visible = True
        MSE_dialog.ShowDialog()

        If MSE_dialog.DialogResult = Windows.Forms.DialogResult.OK Then
            open.Filter = "Mii appareance file|*.MiitopiaMiA"
            open.Title = "Open a Miitopia Mii appareance file"
            open.ShowDialog()
            Miiappareance = open.FileName
            Try
                Dim ReadMiA As New PackageIO.Reader(Miiappareance, PackageIO.Endian.Little)
                ReadMiA.Position = &H0
                Text_Mii_appareanceI.Text = ReadMiA.ReadHexString(&H7C8)
                ReadMiA.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to read Miitopia Mii appareance file" & vbNewLine & "Select a valid Miitopia Mii appareance file or report this issue"
                MSE_dialog.ShowDialog()
            End Try
            Try
                Dim Writer As New PackageIO.Writer(CStr(mainsav), PackageIO.Endian.Little)
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(0) Then
                    Writer.Position = Mii_appareance_1
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(1) Then
                    Writer.Position = Mii_appareance_2
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(2) Then
                    Writer.Position = Mii_appareance_3
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(3) Then
                    Writer.Position = Mii_appareance_4
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(4) Then
                    Writer.Position = Mii_appareance_5
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(5) Then
                    Writer.Position = Mii_appareance_6
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(6) Then
                    Writer.Position = Mii_appareance_7
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(7) Then
                    Writer.Position = Mii_appareance_8
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(8) Then
                    Writer.Position = Mii_appareance_9
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(9) Then
                    Writer.Position = Mii_appareance_10
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(10) Then
                    Writer.Position = Mii_appareance_11
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(11) Then
                    Writer.Position = Mii_appareance_12
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(12) Then
                    Writer.Position = Mii_appareance_13
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(13) Then
                    Writer.Position = Mii_appareance_14
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(14) Then
                    Writer.Position = Mii_appareance_15
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(15) Then
                    Writer.Position = Mii_appareance_16
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(16) Then
                    Writer.Position = Mii_appareance_17
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(17) Then
                    Writer.Position = Mii_appareance_18
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(18) Then
                    Writer.Position = Mii_appareance_19
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(19) Then
                    Writer.Position = Mii_appareance_20
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(20) Then
                    Writer.Position = Mii_appareance_21
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(21) Then
                    Writer.Position = Mii_appareance_22
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(22) Then
                    Writer.Position = Mii_appareance_23
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(23) Then
                    Writer.Position = Mii_appareance_24
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(24) Then
                    Writer.Position = Mii_appareance_25
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(25) Then
                    Writer.Position = Mii_appareance_26
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(26) Then
                    Writer.Position = Mii_appareance_27
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(27) Then
                    Writer.Position = Mii_appareance_28
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(28) Then
                    Writer.Position = Mii_appareance_29
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(29) Then
                    Writer.Position = Mii_appareance_30
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(30) Then
                    Writer.Position = Mii_appareance_31
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(31) Then
                    Writer.Position = Mii_appareance_32
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(32) Then
                    Writer.Position = Mii_appareance_33
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(33) Then
                    Writer.Position = Mii_appareance_34
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(34) Then
                    Writer.Position = Mii_appareance_35
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(35) Then
                    Writer.Position = Mii_appareance_36
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(36) Then
                    Writer.Position = Mii_appareance_37
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(37) Then
                    Writer.Position = Mii_appareance_38
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(38) Then
                    Writer.Position = Mii_appareance_39
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(39) Then
                    Writer.Position = Mii_appareance_40
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(40) Then
                    Writer.Position = Mii_appareance_41
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(41) Then
                    Writer.Position = Mii_appareance_42
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(42) Then
                    Writer.Position = Mii_appareance_43
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(43) Then
                    Writer.Position = Mii_appareance_44
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(44) Then
                    Writer.Position = Mii_appareance_45
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(45) Then
                    Writer.Position = Mii_appareance_46
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(46) Then
                    Writer.Position = Mii_appareance_47
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(47) Then
                    Writer.Position = Mii_appareance_48
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(48) Then
                    Writer.Position = Mii_appareance_49
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(49) Then
                    Writer.Position = Mii_appareance_50
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(50) Then
                    Writer.Position = Mii_appareance_51
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(51) Then
                    Writer.Position = Mii_appareance_52
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(52) Then
                    Writer.Position = Mii_appareance_53
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(53) Then
                    Writer.Position = Mii_appareance_54
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(54) Then
                    Writer.Position = Mii_appareance_55
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(55) Then
                    Writer.Position = Mii_appareance_56
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(56) Then
                    Writer.Position = Mii_appareance_57
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(57) Then
                    Writer.Position = Mii_appareance_58
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(58) Then
                    Writer.Position = Mii_appareance_59
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(59) Then
                    Writer.Position = Mii_appareance_60
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(60) Then
                    Writer.Position = Mii_appareance_61
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(61) Then
                    Writer.Position = Mii_appareance_62
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(62) Then
                    Writer.Position = Mii_appareance_63
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(63) Then
                    Writer.Position = Mii_appareance_64
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(64) Then
                    Writer.Position = Mii_appareance_65
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(65) Then
                    Writer.Position = Mii_appareance_66
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(66) Then
                    Writer.Position = Mii_appareance_67
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(67) Then
                    Writer.Position = Mii_appareance_68
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(68) Then
                    Writer.Position = Mii_appareance_69
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(69) Then
                    Writer.Position = Mii_appareance_70
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(70) Then
                    Writer.Position = Mii_appareance_71
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(71) Then
                    Writer.Position = Mii_appareance_72
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(72) Then
                    Writer.Position = Mii_appareance_73
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(73) Then
                    Writer.Position = Mii_appareance_74
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(74) Then
                    Writer.Position = Mii_appareance_75
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(75) Then
                    Writer.Position = Mii_appareance_76
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(76) Then
                    Writer.Position = Mii_appareance_77
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(77) Then
                    Writer.Position = Mii_appareance_78
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(78) Then
                    Writer.Position = Mii_appareance_79
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(79) Then
                    Writer.Position = Mii_appareance_80
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(80) Then
                    Writer.Position = Mii_appareance_81
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(81) Then
                    Writer.Position = Mii_appareance_82
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(82) Then
                    Writer.Position = Mii_appareance_83
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(83) Then
                    Writer.Position = Mii_appareance_84
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(84) Then
                    Writer.Position = Mii_appareance_85
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(85) Then
                    Writer.Position = Mii_appareance_86
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(86) Then
                    Writer.Position = Mii_appareance_87
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(87) Then
                    Writer.Position = Mii_appareance_88
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(88) Then
                    Writer.Position = Mii_appareance_89
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(89) Then
                    Writer.Position = Mii_appareance_90
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(90) Then
                    Writer.Position = Mii_appareance_91
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(91) Then
                    Writer.Position = Mii_appareance_92
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(92) Then
                    Writer.Position = Mii_appareance_93
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(93) Then
                    Writer.Position = Mii_appareance_94
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(94) Then
                    Writer.Position = Mii_appareance_95
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(95) Then
                    Writer.Position = Mii_appareance_96
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(96) Then
                    Writer.Position = Mii_appareance_97
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(97) Then
                    Writer.Position = Mii_appareance_98
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(98) Then
                    Writer.Position = Mii_appareance_99
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(99) Then
                    Writer.Position = Mii_appareance_100
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(100) Then
                    Writer.Position = Mii_appareance_101
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(101) Then
                    Writer.Position = Mii_appareance_102
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(102) Then
                    Writer.Position = Mii_appareance_103
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(103) Then
                    Writer.Position = Mii_appareance_104
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(104) Then
                    Writer.Position = Mii_appareance_105
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(105) Then
                    Writer.Position = Mii_appareance_106
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(106) Then
                    Writer.Position = Mii_appareance_107
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(107) Then
                    Writer.Position = Mii_appareance_108
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(108) Then
                    Writer.Position = Mii_appareance_109
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(109) Then
                    Writer.Position = Mii_appareance_110
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(110) Then
                    Writer.Position = Mii_appareance_111
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(111) Then
                    Writer.Position = Mii_appareance_112
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(112) Then
                    Writer.Position = Mii_appareance_113
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(113) Then
                    Writer.Position = Mii_appareance_114
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(114) Then
                    Writer.Position = Mii_appareance_115
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(115) Then
                    Writer.Position = Mii_appareance_116
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(116) Then
                    Writer.Position = Mii_appareance_117
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(117) Then
                    Writer.Position = Mii_appareance_118
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(118) Then
                    Writer.Position = Mii_appareance_119
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(119) Then
                    Writer.Position = Mii_appareance_120
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(120) Then
                    Writer.Position = Mii_appareance_121
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(121) Then
                    Writer.Position = Mii_appareance_122
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(122) Then
                    Writer.Position = Mii_appareance_123
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(123) Then
                    Writer.Position = Mii_appareance_124
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(124) Then
                    Writer.Position = Mii_appareance_125
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(125) Then
                    Writer.Position = Mii_appareance_126
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(126) Then
                    Writer.Position = Mii_appareance_127
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(127) Then
                    Writer.Position = Mii_appareance_128
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(128) Then
                    Writer.Position = Mii_appareance_129
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(129) Then
                    Writer.Position = Mii_appareance_130
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(130) Then
                    Writer.Position = Mii_appareance_131
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(131) Then
                    Writer.Position = Mii_appareance_132
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(132) Then
                    Writer.Position = Mii_appareance_133
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(133) Then
                    Writer.Position = Mii_appareance_134
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(134) Then
                    Writer.Position = Mii_appareance_135
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(135) Then
                    Writer.Position = Mii_appareance_136
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(136) Then
                    Writer.Position = Mii_appareance_137
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(137) Then
                    Writer.Position = Mii_appareance_138
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(138) Then
                    Writer.Position = Mii_appareance_139
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(139) Then
                    Writer.Position = Mii_appareance_140
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(140) Then
                    Writer.Position = Mii_appareance_141
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(141) Then
                    Writer.Position = Mii_appareance_142
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(142) Then
                    Writer.Position = Mii_appareance_143
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(143) Then
                    Writer.Position = Mii_appareance_144
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(144) Then
                    Writer.Position = Mii_appareance_145
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(145) Then
                    Writer.Position = Mii_appareance_146
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(146) Then
                    Writer.Position = Mii_appareance_147
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(147) Then
                    Writer.Position = Mii_appareance_148
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(148) Then
                    Writer.Position = Mii_appareance_149
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(149) Then
                    Writer.Position = Mii_appareance_150
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(150) Then
                    Writer.Position = Mii_appareance_151
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(151) Then
                    Writer.Position = Mii_appareance_152
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(152) Then
                    Writer.Position = Mii_appareance_153
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(153) Then
                    Writer.Position = Mii_appareance_154
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(154) Then
                    Writer.Position = Mii_appareance_155
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(155) Then
                    Writer.Position = Mii_appareance_156
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(156) Then
                    Writer.Position = Mii_appareance_157
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(157) Then
                    Writer.Position = Mii_appareance_158
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(158) Then
                    Writer.Position = Mii_appareance_159
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(159) Then
                    Writer.Position = Mii_appareance_160
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(160) Then
                    Writer.Position = Mii_appareance_161
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(161) Then
                    Writer.Position = Mii_appareance_162
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(162) Then
                    Writer.Position = Mii_appareance_163
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(163) Then
                    Writer.Position = Mii_appareance_164
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(164) Then
                    Writer.Position = Mii_appareance_165
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(165) Then
                    Writer.Position = Mii_appareance_166
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(166) Then
                    Writer.Position = Mii_appareance_167
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(167) Then
                    Writer.Position = Mii_appareance_168
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(168) Then
                    Writer.Position = Mii_appareance_169
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(169) Then
                    Writer.Position = Mii_appareance_170
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(170) Then
                    Writer.Position = Mii_appareance_171
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(171) Then
                    Writer.Position = Mii_appareance_172
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(172) Then
                    Writer.Position = Mii_appareance_173
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(173) Then
                    Writer.Position = Mii_appareance_174
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(174) Then
                    Writer.Position = Mii_appareance_175
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(175) Then
                    Writer.Position = Mii_appareance_176
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(176) Then
                    Writer.Position = Mii_appareance_177
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(177) Then
                    Writer.Position = Mii_appareance_178
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(178) Then
                    Writer.Position = Mii_appareance_179
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(179) Then
                    Writer.Position = Mii_appareance_180
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(180) Then
                    Writer.Position = Mii_appareance_181
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(181) Then
                    Writer.Position = Mii_appareance_182
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(182) Then
                    Writer.Position = Mii_appareance_183
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(183) Then
                    Writer.Position = Mii_appareance_184
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(184) Then
                    Writer.Position = Mii_appareance_185
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(185) Then
                    Writer.Position = Mii_appareance_186
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(186) Then
                    Writer.Position = Mii_appareance_187
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(187) Then
                    Writer.Position = Mii_appareance_188
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(188) Then
                    Writer.Position = Mii_appareance_189
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(189) Then
                    Writer.Position = Mii_appareance_190
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(190) Then
                    Writer.Position = Mii_appareance_191
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(191) Then
                    Writer.Position = Mii_appareance_192
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(192) Then
                    Writer.Position = Mii_appareance_193
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(193) Then
                    Writer.Position = Mii_appareance_194
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(194) Then
                    Writer.Position = Mii_appareance_195
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(195) Then
                    Writer.Position = Mii_appareance_196
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(196) Then
                    Writer.Position = Mii_appareance_197
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(197) Then
                    Writer.Position = Mii_appareance_198
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(198) Then
                    Writer.Position = Mii_appareance_199
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(199) Then
                    Writer.Position = Mii_appareance_200
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(200) Then
                    Writer.Position = Mii_appareance_201
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(201) Then
                    Writer.Position = Mii_appareance_202
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(202) Then
                    Writer.Position = Mii_appareance_203
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(203) Then
                    Writer.Position = Mii_appareance_204
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(204) Then
                    Writer.Position = Mii_appareance_205
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(205) Then
                    Writer.Position = Mii_appareance_206
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(206) Then
                    Writer.Position = Mii_appareance_207
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(207) Then
                    Writer.Position = Mii_appareance_208
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(208) Then
                    Writer.Position = Mii_appareance_209
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(209) Then
                    Writer.Position = Mii_appareance_210
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(210) Then
                    Writer.Position = Mii_appareance_211
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(211) Then
                    Writer.Position = Mii_appareance_212
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(212) Then
                    Writer.Position = Mii_appareance_213
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(213) Then
                    Writer.Position = Mii_appareance_214
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(214) Then
                    Writer.Position = Mii_appareance_215
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(215) Then
                    Writer.Position = Mii_appareance_216
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(216) Then
                    Writer.Position = Mii_appareance_217
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(217) Then
                    Writer.Position = Mii_appareance_218
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(218) Then
                    Writer.Position = Mii_appareance_219
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(219) Then
                    Writer.Position = Mii_appareance_220
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(220) Then
                    Writer.Position = Mii_appareance_221
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(221) Then
                    Writer.Position = Mii_appareance_222
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(222) Then
                    Writer.Position = Mii_appareance_223
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(223) Then
                    Writer.Position = Mii_appareance_224
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(224) Then
                    Writer.Position = Mii_appareance_225
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(225) Then
                    Writer.Position = Mii_appareance_226
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(226) Then
                    Writer.Position = Mii_appareance_227
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(227) Then
                    Writer.Position = Mii_appareance_228
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(228) Then
                    Writer.Position = Mii_appareance_229
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(229) Then
                    Writer.Position = Mii_appareance_230
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(230) Then
                    Writer.Position = Mii_appareance_231
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(231) Then
                    Writer.Position = Mii_appareance_232
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(232) Then
                    Writer.Position = Mii_appareance_233
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(233) Then
                    Writer.Position = Mii_appareance_234
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(234) Then
                    Writer.Position = Mii_appareance_235
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(235) Then
                    Writer.Position = Mii_appareance_236
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(236) Then
                    Writer.Position = Mii_appareance_237
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(237) Then
                    Writer.Position = Mii_appareance_238
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(238) Then
                    Writer.Position = Mii_appareance_239
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(239) Then
                    Writer.Position = Mii_appareance_240
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(240) Then
                    Writer.Position = Mii_appareance_241
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(241) Then
                    Writer.Position = Mii_appareance_242
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(242) Then
                    Writer.Position = Mii_appareance_243
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(243) Then
                    Writer.Position = Mii_appareance_244
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(244) Then
                    Writer.Position = Mii_appareance_245
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(245) Then
                    Writer.Position = Mii_appareance_246
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(246) Then
                    Writer.Position = Mii_appareance_247
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(247) Then
                    Writer.Position = Mii_appareance_248
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(248) Then
                    Writer.Position = Mii_appareance_249
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(249) Then
                    Writer.Position = Mii_appareance_250
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(250) Then
                    Writer.Position = Mii_appareance_251
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(251) Then
                    Writer.Position = Mii_appareance_252
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(252) Then
                    Writer.Position = Mii_appareance_253
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(253) Then
                    Writer.Position = Mii_appareance_254
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(254) Then
                    Writer.Position = Mii_appareance_255
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(255) Then
                    Writer.Position = Mii_appareance_256
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(256) Then
                    Writer.Position = Mii_appareance_257
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(257) Then
                    Writer.Position = Mii_appareance_258
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(258) Then
                    Writer.Position = Mii_appareance_259
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(259) Then
                    Writer.Position = Mii_appareance_260
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(260) Then
                    Writer.Position = Mii_appareance_261
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(261) Then
                    Writer.Position = Mii_appareance_262
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(262) Then
                    Writer.Position = Mii_appareance_263
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(263) Then
                    Writer.Position = Mii_appareance_264
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(264) Then
                    Writer.Position = Mii_appareance_265
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(265) Then
                    Writer.Position = Mii_appareance_266
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(266) Then
                    Writer.Position = Mii_appareance_267
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(267) Then
                    Writer.Position = Mii_appareance_268
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(268) Then
                    Writer.Position = Mii_appareance_269
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(269) Then
                    Writer.Position = Mii_appareance_270
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(270) Then
                    Writer.Position = Mii_appareance_271
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(271) Then
                    Writer.Position = Mii_appareance_272
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(272) Then
                    Writer.Position = Mii_appareance_273
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(273) Then
                    Writer.Position = Mii_appareance_274
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(274) Then
                    Writer.Position = Mii_appareance_275
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(275) Then
                    Writer.Position = Mii_appareance_276
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(276) Then
                    Writer.Position = Mii_appareance_277
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(277) Then
                    Writer.Position = Mii_appareance_278
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(278) Then
                    Writer.Position = Mii_appareance_279
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(279) Then
                    Writer.Position = Mii_appareance_280
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(280) Then
                    Writer.Position = Mii_appareance_281
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(281) Then
                    Writer.Position = Mii_appareance_282
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(282) Then
                    Writer.Position = Mii_appareance_283
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(283) Then
                    Writer.Position = Mii_appareance_284
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(284) Then
                    Writer.Position = Mii_appareance_285
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(285) Then
                    Writer.Position = Mii_appareance_286
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(286) Then
                    Writer.Position = Mii_appareance_287
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(287) Then
                    Writer.Position = Mii_appareance_288
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(288) Then
                    Writer.Position = Mii_appareance_289
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(289) Then
                    Writer.Position = Mii_appareance_290
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(290) Then
                    Writer.Position = Mii_appareance_291
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(291) Then
                    Writer.Position = Mii_appareance_292
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(292) Then
                    Writer.Position = Mii_appareance_293
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(293) Then
                    Writer.Position = Mii_appareance_294
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(294) Then
                    Writer.Position = Mii_appareance_295
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(295) Then
                    Writer.Position = Mii_appareance_296
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(296) Then
                    Writer.Position = Mii_appareance_297
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(297) Then
                    Writer.Position = Mii_appareance_298
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(298) Then
                    Writer.Position = Mii_appareance_299
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(299) Then
                    Writer.Position = Mii_appareance_300
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(300) Then
                    Writer.Position = Mii_appareance_301
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(301) Then
                    Writer.Position = Mii_appareance_302
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(302) Then
                    Writer.Position = Mii_appareance_303
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(303) Then
                    Writer.Position = Mii_appareance_304
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(304) Then
                    Writer.Position = Mii_appareance_305
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(305) Then
                    Writer.Position = Mii_appareance_306
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(306) Then
                    Writer.Position = Mii_appareance_307
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(307) Then
                    Writer.Position = Mii_appareance_308
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(308) Then
                    Writer.Position = Mii_appareance_309
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(309) Then
                    Writer.Position = Mii_appareance_310
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(310) Then
                    Writer.Position = Mii_appareance_311
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(311) Then
                    Writer.Position = Mii_appareance_312
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(312) Then
                    Writer.Position = Mii_appareance_313
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(313) Then
                    Writer.Position = Mii_appareance_314
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(314) Then
                    Writer.Position = Mii_appareance_315
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(315) Then
                    Writer.Position = Mii_appareance_316
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(316) Then
                    Writer.Position = Mii_appareance_317
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(317) Then
                    Writer.Position = Mii_appareance_318
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(318) Then
                    Writer.Position = Mii_appareance_319
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(319) Then
                    Writer.Position = Mii_appareance_320
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(320) Then
                    Writer.Position = Mii_appareance_321
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(321) Then
                    Writer.Position = Mii_appareance_322
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(322) Then
                    Writer.Position = Mii_appareance_323
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(323) Then
                    Writer.Position = Mii_appareance_324
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(324) Then
                    Writer.Position = Mii_appareance_325
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(325) Then
                    Writer.Position = Mii_appareance_326
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(326) Then
                    Writer.Position = Mii_appareance_327
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(327) Then
                    Writer.Position = Mii_appareance_328
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(328) Then
                    Writer.Position = Mii_appareance_329
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(329) Then
                    Writer.Position = Mii_appareance_330
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(330) Then
                    Writer.Position = Mii_appareance_331
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(331) Then
                    Writer.Position = Mii_appareance_332
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(332) Then
                    Writer.Position = Mii_appareance_333
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(333) Then
                    Writer.Position = Mii_appareance_334
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(334) Then
                    Writer.Position = Mii_appareance_335
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(335) Then
                    Writer.Position = Mii_appareance_336
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(336) Then
                    Writer.Position = Mii_appareance_337
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(337) Then
                    Writer.Position = Mii_appareance_338
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(338) Then
                    Writer.Position = Mii_appareance_339
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(339) Then
                    Writer.Position = Mii_appareance_340
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(340) Then
                    Writer.Position = Mii_appareance_341
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(341) Then
                    Writer.Position = Mii_appareance_342
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(342) Then
                    Writer.Position = Mii_appareance_343
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(343) Then
                    Writer.Position = Mii_appareance_344
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(344) Then
                    Writer.Position = Mii_appareance_345
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(345) Then
                    Writer.Position = Mii_appareance_346
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(346) Then
                    Writer.Position = Mii_appareance_347
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(347) Then
                    Writer.Position = Mii_appareance_348
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(348) Then
                    Writer.Position = Mii_appareance_349
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(349) Then
                    Writer.Position = Mii_appareance_350
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(350) Then
                    Writer.Position = Mii_appareance_351
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(351) Then
                    Writer.Position = Mii_appareance_352
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(352) Then
                    Writer.Position = Mii_appareance_353
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(353) Then
                    Writer.Position = Mii_appareance_354
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(354) Then
                    Writer.Position = Mii_appareance_355
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(355) Then
                    Writer.Position = Mii_appareance_356
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(356) Then
                    Writer.Position = Mii_appareance_357
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(357) Then
                    Writer.Position = Mii_appareance_358
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(358) Then
                    Writer.Position = Mii_appareance_359
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(359) Then
                    Writer.Position = Mii_appareance_360
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(360) Then
                    Writer.Position = Mii_appareance_361
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(361) Then
                    Writer.Position = Mii_appareance_362
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(362) Then
                    Writer.Position = Mii_appareance_363
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(363) Then
                    Writer.Position = Mii_appareance_364
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(364) Then
                    Writer.Position = Mii_appareance_365
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(365) Then
                    Writer.Position = Mii_appareance_366
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(366) Then
                    Writer.Position = Mii_appareance_367
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(367) Then
                    Writer.Position = Mii_appareance_368
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(368) Then
                    Writer.Position = Mii_appareance_369
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(369) Then
                    Writer.Position = Mii_appareance_370
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(370) Then
                    Writer.Position = Mii_appareance_371
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(371) Then
                    Writer.Position = Mii_appareance_372
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(372) Then
                    Writer.Position = Mii_appareance_373
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(373) Then
                    Writer.Position = Mii_appareance_374
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(374) Then
                    Writer.Position = Mii_appareance_375
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(375) Then
                    Writer.Position = Mii_appareance_376
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(376) Then
                    Writer.Position = Mii_appareance_377
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(377) Then
                    Writer.Position = Mii_appareance_378
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(378) Then
                    Writer.Position = Mii_appareance_379
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(379) Then
                    Writer.Position = Mii_appareance_380
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(380) Then
                    Writer.Position = Mii_appareance_381
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(381) Then
                    Writer.Position = Mii_appareance_382
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(382) Then
                    Writer.Position = Mii_appareance_383
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(383) Then
                    Writer.Position = Mii_appareance_384
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(384) Then
                    Writer.Position = Mii_appareance_385
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(385) Then
                    Writer.Position = Mii_appareance_386
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(386) Then
                    Writer.Position = Mii_appareance_387
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(387) Then
                    Writer.Position = Mii_appareance_388
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(388) Then
                    Writer.Position = Mii_appareance_389
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(389) Then
                    Writer.Position = Mii_appareance_390
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(390) Then
                    Writer.Position = Mii_appareance_391
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(391) Then
                    Writer.Position = Mii_appareance_392
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(392) Then
                    Writer.Position = Mii_appareance_393
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(393) Then
                    Writer.Position = Mii_appareance_394
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(394) Then
                    Writer.Position = Mii_appareance_395
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(395) Then
                    Writer.Position = Mii_appareance_396
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(396) Then
                    Writer.Position = Mii_appareance_397
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(397) Then
                    Writer.Position = Mii_appareance_398
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(398) Then
                    Writer.Position = Mii_appareance_399
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(399) Then
                    Writer.Position = Mii_appareance_400
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(400) Then
                    Writer.Position = Mii_appareance_401
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(401) Then
                    Writer.Position = Mii_appareance_402
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(402) Then
                    Writer.Position = Mii_appareance_403
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(403) Then
                    Writer.Position = Mii_appareance_404
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(404) Then
                    Writer.Position = Mii_appareance_405
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(405) Then
                    Writer.Position = Mii_appareance_406
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(406) Then
                    Writer.Position = Mii_appareance_407
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(407) Then
                    Writer.Position = Mii_appareance_408
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(408) Then
                    Writer.Position = Mii_appareance_409
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(409) Then
                    Writer.Position = Mii_appareance_410
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(410) Then
                    Writer.Position = Mii_appareance_411
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(411) Then
                    Writer.Position = Mii_appareance_412
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(412) Then
                    Writer.Position = Mii_appareance_413
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(413) Then
                    Writer.Position = Mii_appareance_414
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(414) Then
                    Writer.Position = Mii_appareance_415
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(415) Then
                    Writer.Position = Mii_appareance_416
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(416) Then
                    Writer.Position = Mii_appareance_417
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(417) Then
                    Writer.Position = Mii_appareance_418
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(418) Then
                    Writer.Position = Mii_appareance_419
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(419) Then
                    Writer.Position = Mii_appareance_420
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(420) Then
                    Writer.Position = Mii_appareance_421
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(421) Then
                    Writer.Position = Mii_appareance_422
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(422) Then
                    Writer.Position = Mii_appareance_423
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(423) Then
                    Writer.Position = Mii_appareance_424
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(424) Then
                    Writer.Position = Mii_appareance_425
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(425) Then
                    Writer.Position = Mii_appareance_426
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(426) Then
                    Writer.Position = Mii_appareance_427
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(427) Then
                    Writer.Position = Mii_appareance_428
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(428) Then
                    Writer.Position = Mii_appareance_429
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(429) Then
                    Writer.Position = Mii_appareance_430
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(430) Then
                    Writer.Position = Mii_appareance_431
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(431) Then
                    Writer.Position = Mii_appareance_432
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(432) Then
                    Writer.Position = Mii_appareance_433
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(433) Then
                    Writer.Position = Mii_appareance_434
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(434) Then
                    Writer.Position = Mii_appareance_435
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(435) Then
                    Writer.Position = Mii_appareance_436
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(436) Then
                    Writer.Position = Mii_appareance_437
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(437) Then
                    Writer.Position = Mii_appareance_438
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(438) Then
                    Writer.Position = Mii_appareance_439
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(439) Then
                    Writer.Position = Mii_appareance_440
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(440) Then
                    Writer.Position = Mii_appareance_441
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(441) Then
                    Writer.Position = Mii_appareance_442
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(442) Then
                    Writer.Position = Mii_appareance_443
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(443) Then
                    Writer.Position = Mii_appareance_444
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(444) Then
                    Writer.Position = Mii_appareance_445
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(445) Then
                    Writer.Position = Mii_appareance_446
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(446) Then
                    Writer.Position = Mii_appareance_447
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(447) Then
                    Writer.Position = Mii_appareance_448
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(448) Then
                    Writer.Position = Mii_appareance_449
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(449) Then
                    Writer.Position = Mii_appareance_450
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(450) Then
                    Writer.Position = Mii_appareance_451
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(451) Then
                    Writer.Position = Mii_appareance_452
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(452) Then
                    Writer.Position = Mii_appareance_453
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(453) Then
                    Writer.Position = Mii_appareance_454
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(454) Then
                    Writer.Position = Mii_appareance_455
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(455) Then
                    Writer.Position = Mii_appareance_456
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(456) Then
                    Writer.Position = Mii_appareance_457
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(457) Then
                    Writer.Position = Mii_appareance_458
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(458) Then
                    Writer.Position = Mii_appareance_459
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(459) Then
                    Writer.Position = Mii_appareance_460
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(460) Then
                    Writer.Position = Mii_appareance_461
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(461) Then
                    Writer.Position = Mii_appareance_462
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(462) Then
                    Writer.Position = Mii_appareance_463
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(463) Then
                    Writer.Position = Mii_appareance_464
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(464) Then
                    Writer.Position = Mii_appareance_465
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(465) Then
                    Writer.Position = Mii_appareance_466
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(466) Then
                    Writer.Position = Mii_appareance_467
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(467) Then
                    Writer.Position = Mii_appareance_468
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(468) Then
                    Writer.Position = Mii_appareance_469
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(469) Then
                    Writer.Position = Mii_appareance_470
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(470) Then
                    Writer.Position = Mii_appareance_471
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(471) Then
                    Writer.Position = Mii_appareance_472
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(472) Then
                    Writer.Position = Mii_appareance_473
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(473) Then
                    Writer.Position = Mii_appareance_474
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(474) Then
                    Writer.Position = Mii_appareance_475
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(475) Then
                    Writer.Position = Mii_appareance_476
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(476) Then
                    Writer.Position = Mii_appareance_477
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(477) Then
                    Writer.Position = Mii_appareance_478
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(478) Then
                    Writer.Position = Mii_appareance_479
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(479) Then
                    Writer.Position = Mii_appareance_480
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(480) Then
                    Writer.Position = Mii_appareance_481
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(481) Then
                    Writer.Position = Mii_appareance_482
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(482) Then
                    Writer.Position = Mii_appareance_483
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(483) Then
                    Writer.Position = Mii_appareance_484
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(484) Then
                    Writer.Position = Mii_appareance_485
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(485) Then
                    Writer.Position = Mii_appareance_486
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(486) Then
                    Writer.Position = Mii_appareance_487
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(487) Then
                    Writer.Position = Mii_appareance_488
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(488) Then
                    Writer.Position = Mii_appareance_489
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(489) Then
                    Writer.Position = Mii_appareance_490
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(490) Then
                    Writer.Position = Mii_appareance_491
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(491) Then
                    Writer.Position = Mii_appareance_492
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(492) Then
                    Writer.Position = Mii_appareance_493
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(493) Then
                    Writer.Position = Mii_appareance_494
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(494) Then
                    Writer.Position = Mii_appareance_495
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(495) Then
                    Writer.Position = Mii_appareance_496
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(496) Then
                    Writer.Position = Mii_appareance_497
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(497) Then
                    Writer.Position = Mii_appareance_498
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(498) Then
                    Writer.Position = Mii_appareance_499
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                If Select_Mii.SelectedItem = Select_Mii.Items.Item(499) Then
                    Writer.Position = Mii_appareance_500
                    Writer.WriteHexString(Text_Mii_appareanceI.Text)
                End If
                MSE_dialog.text_dialog.Text = "This Mii appareance has been successfully replaced, you will be back to menu"
                MSE_dialog.ShowDialog()
                MSE_hub.Show()
                Me.Close()
            Catch ex As Exception
                MSE_dialog.text_dialog.Text = "Failed to write Mii appareance" & vbNewLine & "Make sure you have opened a Miitopia save file before or report this issue"
                MSE_dialog.ShowDialog()
            End Try
        End If
    End Sub

    Private Sub Icon_import_MouseMove(sender As Object, e As MouseEventArgs) Handles Icon_import.MouseMove
        Text_description.Text = "Click to import a Mii appareance"
        Panel_description.Visible = True
    End Sub

    Private Sub Icon_import_MouseLeave(sender As Object, e As EventArgs) Handles Icon_import.MouseLeave
        Panel_description.Visible = False
    End Sub
End Class