# New ports collection makefile for:	texlive-ptex
# Date created:		09/21/2010 11:41:31
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	ptex
PORTVERSION=	20111104
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX system for publishing in Japanese.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/LICENSE:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/ipaex/otf-ipa.map:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
