# New ports collection makefile for:	texlive-bin-csplain
# Date created:		26/01/2009 16:06:02
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-csplain
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Plain TeX support for Czech/Slovak typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
