# $FreeBSD$

PORTNAME=	collection-langjapanese
PORTVERSION=	20150412
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Japanese

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/dvips/base/color.pro:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/etex/xbmc10.mf:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf-dist/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-lib/3test.mf:${PORTSDIR}/print/texlive-knuth-lib \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/knuth-local/black.mf:${PORTSDIR}/print/texlive-knuth-local \
		${LOCALBASE}/share/texmf-dist/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/mf.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf-dist/dvips/xdvi/config.xdvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/LICENSE:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/c90/c90.enc:${PORTSDIR}/print/texlive-c90 \
		${LOCALBASE}/share/texmf-dist/scripts/cjk-gs-integrate/cjk-gs-integrate.pl:${PORTSDIR}/print/texlive-cjk-gs-integrate \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk/contrib/wadalab/c42goth.fd:${PORTSDIR}/print/texlive-cjk \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjkpunct/CJKpunct.sty:${PORTSDIR}/print/texlive-cjkpunct \
		${LOCALBASE}/share/texmf-dist/hbf2gf/README:${PORTSDIR}/print/texlive-cjkutils \
		${LOCALBASE}/share/texmf-dist/fonts/sfd/dnp/DNP.sfd:${PORTSDIR}/print/texlive-dnp \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcjk2uni/cmap/c0001.cmap:${PORTSDIR}/print/texlive-xcjk2uni \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafont/zxjafont.sty:${PORTSDIR}/print/texlive-zxjafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxbase/bxbase.sty:${PORTSDIR}/print/texlive-bxbase \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxcjkjatype/bxcjkjatype.sty:${PORTSDIR}/print/texlive-bxcjkjatype \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxjscls/bxjsarticle.cls:${PORTSDIR}/print/texlive-bxjscls \
		${LOCALBASE}/share/texmf-dist/scripts/convbkmk/convbkmk.rb:${PORTSDIR}/print/texlive-convbkmk \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf \
		${LOCALBASE}/share/texmf-dist/fonts/ovp/public/japanese-otf-uptex/upphirakakuw3-h.ovp:${PORTSDIR}/print/texlive-japanese-otf-uptex \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/jfontmaps/2004-H:${PORTSDIR}/print/texlive-jfontmaps \
		${LOCALBASE}/share/texmf-dist/tex/platex/jsclasses/jsarticle.cls:${PORTSDIR}/print/texlive-jsclasses \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luatexja/luatexja.sty:${PORTSDIR}/print/texlive-luatexja \
		${LOCALBASE}/share/texmf-dist/tex/ptex/base/ptex.tex:${PORTSDIR}/print/texlive-ptex \
		${LOCALBASE}/share/texmf-dist/scripts/ptex2pdf/ptex2pdf.lua:${PORTSDIR}/print/texlive-ptex2pdf \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxbase/pxbase.sty:${PORTSDIR}/print/texlive-pxbase \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxchfon/pxchfon.sty:${PORTSDIR}/print/texlive-pxchfon \
		${LOCALBASE}/share/texmf-dist/tex/latex/pxcjkcat/pxcjkcat.sty:${PORTSDIR}/print/texlive-pxcjkcat \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxjahyper/pxjahyper.sty:${PORTSDIR}/print/texlive-pxjahyper \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxrubrica/pxrubrica.sty:${PORTSDIR}/print/texlive-pxrubrica \
		${LOCALBASE}/share/texmf-dist/tex/uptex/base/uptex.tex:${PORTSDIR}/print/texlive-uptex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/wadalab/dgj/dgjgreek.afm:${PORTSDIR}/print/texlive-wadalab \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafbfont/zxjafbfont.sty:${PORTSDIR}/print/texlive-zxjafbfont \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjatype/zxjatype.sty:${PORTSDIR}/print/texlive-zxjatype

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
