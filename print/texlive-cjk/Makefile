# $FreeBSD$

PORTNAME=	cjk
PORTVERSION=	20150420
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	CJK language support.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/dvips/arphic/config.bkaiu:${PORTSDIR}/print/texlive-arphic \
		${LOCALBASE}/share/texmf-dist/fonts/misc/cns/4040w0.bin:${PORTSDIR}/print/texlive-cns \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/dvips/uhc/config.uhc:${PORTSDIR}/print/texlive-uhc \
		${LOCALBASE}/share/texmf-dist/fonts/afm/wadalab/dgj/dgjgreek.afm:${PORTSDIR}/print/texlive-wadalab

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
