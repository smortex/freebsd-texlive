# New ports collection makefile for:	texlive-cjk
# Date created:		26/01/2009 16:05:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	cjk
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	CJK language support.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/arphic/config.bkaiu:${PORTSDIR}/print/texlive-arphic \
		${LOCALBASE}/share/texmf-dist/fonts/misc/cns/4040w0.bin:${PORTSDIR}/print/texlive-cns \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/thaifonts/garuda.afm:${PORTSDIR}/print/texlive-thaifonts \
		${LOCALBASE}/share/texmf-dist/dvips/uhc/config.uhc:${PORTSDIR}/print/texlive-uhc \
		${LOCALBASE}/share/texmf-dist/fonts/afm/wadalab/dgj/dgjgreek.afm:${PORTSDIR}/print/texlive-wadalab

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
