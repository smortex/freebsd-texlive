# $FreeBSD$

PORTNAME=	uptex
PORTVERSION=	20141004
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Unicode version of pTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/ptex/base/ptex.tex:${PORTSDIR}/print/texlive-ptex \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/LICENSE:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/scripts/convbkmk/convbkmk.rb:${PORTSDIR}/print/texlive-convbkmk \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
