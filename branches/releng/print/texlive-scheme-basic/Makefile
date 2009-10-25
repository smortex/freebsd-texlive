# New ports collection makefile for:	texlive-scheme-basic
# Date created:		26/01/2009 16:03:06
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	scheme-basic
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	basic scheme (plain and LaTeX)

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/dvips/cm/config.cm:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cmex/ttcmex.map:${PORTSDIR}/print/texlive-cmex \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-bin-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-bin-dvipdfmx \
		${LOCALBASE}/share/texmf/dvips/base/color.pro:${PORTSDIR}/print/texlive-bin-dvipsk \
		${LOCALBASE}/share/texmf/scripts/texlive/getnonfreefonts.pl:${PORTSDIR}/print/texlive-bin-getnonfreefonts \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-bin-gsftopk \
		${LOCALBASE}/share/texmf/fmtutil/format.metafont.cnf:${PORTSDIR}/print/texlive-bin-metafont \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-bin-tetex \
		${LOCALBASE}/share/texmf/fmtutil/fmtutil-hdr.cnf:${PORTSDIR}/print/texlive-bin-texlive \
		${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-bin-texconfig \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-bin-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/fmtutil/format.luatex.cnf:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/latex/ae/ae.sty:${PORTSDIR}/print/texlive-ae \
		${LOCALBASE}/share/texmf-dist/tex/latex/amscls/amsart.cls:${PORTSDIR}/print/texlive-amscls \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsmath/amsmath.sty:${PORTSDIR}/print/texlive-amsmath \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsrefs/amsrefs.sty:${PORTSDIR}/print/texlive-amsrefs \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/tex/latex/babelbib/babelbib.sty:${PORTSDIR}/print/texlive-babelbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/carlisle/blkarray.sty:${PORTSDIR}/print/texlive-carlisle \
		${LOCALBASE}/share/texmf-dist/tex/latex/colortbl/colortbl.sty:${PORTSDIR}/print/texlive-colortbl \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyhdr/fancyhdr.sty:${PORTSDIR}/print/texlive-fancyhdr \
		${LOCALBASE}/share/texmf-dist/tex/latex/geometry/geometry.sty:${PORTSDIR}/print/texlive-geometry \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics/graphics.sty:${PORTSDIR}/print/texlive-graphics \
		${LOCALBASE}/share/texmf-dist/tex/latex/hyperref/hyperref.sty:${PORTSDIR}/print/texlive-hyperref \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bluesky/latex-fonts/lasy10.afm:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/latex.ini:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/ltxmisc/2in1.sty:${PORTSDIR}/print/texlive-ltxmisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfnfss/oldgerm.sty:${PORTSDIR}/print/texlive-mfnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/natbib/natbib.sty:${PORTSDIR}/print/texlive-natbib \
		${LOCALBASE}/share/texmf-dist/scripts/oberdiek/luacolor.lua:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdftex-def/pdftex.def:${PORTSDIR}/print/texlive-pdftex-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/pslatex/pslatex.sty:${PORTSDIR}/print/texlive-pslatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/pspicture/pspicture.sty:${PORTSDIR}/print/texlive-pspicture \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf/fmtutil/format.latex.cnf:${PORTSDIR}/print/texlive-bin-latex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
