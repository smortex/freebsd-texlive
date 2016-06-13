# $FreeBSD$

PORTNAME=	uplatex
PORTVERSION=	20160611
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	pLaTeX2e and miscellaneous macros for upTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/README:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/scripts/convbkmk/convbkmk.rb:${PORTSDIR}/print/texlive-convbkmk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/ptex/morisawa.map:${PORTSDIR}/print/texlive-ptex \
		${LOCALBASE}/share/texmf-dist/tex/uptex/uptex-base/euptex.ini:${PORTSDIR}/print/texlive-uptex-base \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/uptex-fonts/UTF8-UTF16:${PORTSDIR}/print/texlive-uptex-fonts \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
